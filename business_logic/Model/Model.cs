using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using System.Collections.Generic;
using business_logic.Model.UserPack;
using business_logic.Model.PetPack;
using business_logic.Model.MessagePack;
using System.Linq;
using business_logic.Model.RequestPack;
using Entities;


namespace business_logic.Model
{
    public class Model : IModel
    {
        private IEmailHandler emailHandler;
        private IUserManager userManager;
        private IPetManager petManager;
        private IMessageManager messageManager;
        private IRequestManager<Request,string> requestManager;

        private Random random;

        public Model(/*ITier2Mediator tier2Mediator, */IUserManager userManager, 
        IPetManager petManager, IMessageManager messageManager){
            emailHandler = new EmailHandler();
            random = new Random(1538);
            this.userManager = userManager;
            this.petManager = petManager;
            this.messageManager = messageManager;
            requestManager = new RequestManager<Request,string>(
                (request)=> {return request.petId;},(request)=> {return request.userEmail;}
            );
        }
        //////change this down part
        public bool Login(string email){
            try {
                emailHandler.sendEmail(email,"Your login link - PetBook","Testing Hello there! ");
            } catch (Exception exception){
                Console.WriteLine("error occured!"+exception);
                return false;
            }
            return true;
        }
        public async Task<Entities.PetList> getPetsAsync(){
            
            PetList list = await petManager.requestPets();
            return list;
        }//to delete

        public async Task<IList<Entities.Pet>> getPetsAsync(Entities.AuthorisedUser user){
            IList<Pet> thePet = await petManager.requestPets(user);
            return thePet;
        }//to delete

        public async Task<IList<Entities.Pet>> getPetsAsync(int? id, string userEmail, string status, 
        string type, string breed, char? gender, DateTime? birthday, string name){//TODO maybe move to PetManager

            return await petManager.getPetsAsync(id,userEmail,status,type,breed,gender,birthday,name);
        }

        public async Task<Entities.Pet> createPetAsync(Entities.Pet pet,string token){
            string email = userManager.getUserWithToken(token);
            if (email == null){
                throw new AccessViolationException("user is not authorised");
            }
            pet.user = new Entities.User(){
                email = email,
                name = (await userManager.GetUser(email)).name
            };
            Pet newPet = await petManager.createPet(pet);
            if (pet.statuses.Count > 0)
            {
                foreach (var status in pet.statuses)
                {
                    newPet.statuses.Add(status);
                }
                await updatePetAsync(newPet, token);
            }
            return newPet;
        }

        public async Task<Entities.Pet> deletePetAsync(Entities.Pet pet, string token){
            string email = userManager.getUserWithToken(token);
            if (email == null){
                throw new AccessViolationException("user is not authorised");
            }
            Pet realPet =  await petManager.requestPet(pet.id);
            if (!realPet.user.email.Equals(email)){
                throw new AccessViolationException("you do not have right to delete this pet");
            }
            
            await petManager.deletePet(realPet);
            return pet;
        }

        public async Task<Entities.Pet> updatePetAsync(Entities.Pet pet, string token){ // just owner can modify pet
            string email = userManager.getUserWithToken(token);
            if (email == null){
                throw new AccessViolationException("user is not authorised");
            }
            Pet databasePet = await petManager.requestPet(pet.id);
            if (databasePet == null){
                throw new AccessViolationException("pet with that id do not exist");
            }
            if (databasePet.user.email != email){
                throw new AccessViolationException("just owner of pet can modify it.");
            }
            pet.user.email = email;
            pet.user.name = (await userManager.GetUser(email)).name;
            foreach (Status status in pet.statuses){
                status.pet = pet.copy();
                status.pet.statuses = new List<Status>();
            };
            Pet newPet = await petManager.updatePet(pet);
            return newPet;
        }

        public async Task<bool> sendCode(string email){
            if (! await userManager.emailExist(email)){
                return false;
            }
            string code = userManager.MakeUserCode(email);
            emailHandler.sendLoginLink(email,code);
            Console.WriteLine("email is no its way with code: "+code);
            return true;
        }
        public async Task<string> login(string email, string code){
            if (userManager.IsCorrectCode(email,code)){
                return userManager.MakeUserToken(email);
            }
            return "";
        }

        public async Task<Entities.AuthorisedUser> GetAuthorisedUser(string token){
            string email = userManager.getUserWithToken(token);
            if (email == null){
                return null;
            }
            AuthorisedUser user = await userManager.GetUser(email);
            user.pets = (await this.getPetsAsync(null,user.email,null,null,null,null,null,null)).ToArray();
            return user;
        }
        public async Task<Entities.AuthorisedUser> register(Entities.User user){
            //change this
            AuthorisedUser authUsr = new AuthorisedUser(){
                email = user.email,
                name = user.name,
                pets = new Pet[0]
            };
            //Console.WriteLine("something is here");
            if (! await userManager.emailExist(user.email)){
                AuthorisedUser usr = await userManager.CreateUser(authUsr);
                await this.sendCode(user.email);
                Console.WriteLine("efter creating user");
                return usr;
            }
            throw new Exception("email already exist.");
        }

        public async Task sendMessage(Entities.Message message, string token){
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await this.GetAuthorisedUser(token);
            int senderId = message.SenderPetId;
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((Pet pet) => {return pet.id == senderId;}).Count() > 0){
                messageManager.sendMessage(message);
            } else {
                throw new AccessViolationException("you are not owner of the pet.");
            }
        }
        public async Task<IList<Entities.Message>> GetMessages(int receiverPetId, int senderPetId, string token){//make it authenticaitons
            string email = userManager.getUserWithToken(token);
            if ((await this.getPetsAsync(senderPetId,null,null,null,null,null,null,null)).Count == 0){
                await messageManager.getMessages(receiverPetId, senderPetId);
                return new List<Entities.Message>();
            }
            AuthorisedUser usr = await this.GetAuthorisedUser(token);
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((Pet pet) => {return pet.id == receiverPetId;}).Count() > 0){
                return await messageManager.getMessages(receiverPetId,senderPetId);
            } else {
                throw new AccessViolationException("you are not owner of the pet.");
            }
        }

        public async Task<IList<Entities.Pet>> GetMessagePets(int receiverPetId, string token){
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await userManager.GetUser(email);
            usr.pets = (await this.getPetsAsync(null,email,null,null,null,null,null,null)).ToArray();
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((Pet pet) => {return pet.id == receiverPetId;}).Count() > 0){
                IList<int> listOfId = await messageManager.getPetIdOfMessages(receiverPetId);
                List<Pet> petList = new List<Pet>();
                foreach (int petId in listOfId){
                    petList.AddRange(await this.getPetsAsync(petId,null,null,null,null,null,null,null));
                }
                return petList;
            } else {
                throw new AccessViolationException("you are not owner of the pet.");
            }
        }

        public async Task sendRequest(Entities.Request request, string token){
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await this.GetAuthorisedUser(token);
            string senderId = request.userEmail;
            //check if the user own the pet that he want to claim to send the message from
            if (usr.email == senderId){
                requestManager.makeRequest(request);
            } else {
                throw new AccessViolationException("you are not authorised.");
            }
        }

        public async Task<IList<Entities.User>> GetPetRequests(int receiverPetId, string token){
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await userManager.GetUser(email);
            usr.pets = (await this.getPetsAsync(null,email,null,null,null,null,null,null)).ToArray();
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((Pet pet) => {return pet.id == receiverPetId;}).Count() > 0){
                IList<string> emails = requestManager.getRequestsOfPet(receiverPetId);
                IList<User> returnValue = new List<User>();
                foreach (string theEmail in emails){
                    User theUser = await userManager.GetUser(email);
                    if (theUser != null && string.IsNullOrEmpty(theUser.email)){
                        returnValue.Add(theUser);
                    }
                } 
                return returnValue;
            } else {
                throw new AccessViolationException("you are not owner of the pet.");
            }
        }

        public async Task<IList<Entities.Request>> GetRequests(int receiverPetId, string senderUserEmail, string token){//make it authenticaitons
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await this.GetAuthorisedUser(token);
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((thePet)=>{return thePet.id == receiverPetId;}).Count() > 0){
                return requestManager.getRequestOfPetAndUser(receiverPetId,senderUserEmail);
            } else {
                throw new AccessViolationException("you are not owner of the pet.");
            }
        }

        private string createRandomCode(int codeLength){
            string code = "";
            for (int i = 0; i< codeLength;i++){
                char ch =(char)random.Next(65,90+1);
                code += ch.ToString();
            }
            return code;
        }
    }
}