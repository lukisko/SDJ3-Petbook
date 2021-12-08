using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using System.Collections.Generic;
using business_logic.Model.UserPack;
using business_logic.Model.PetPack;
using business_logic.Model.MessagePack;
using System.Linq;

namespace business_logic.Model
{
    public class Model : IModel
    {
        private ITier2Mediator tier2Mediator;
        private IEmailHandler emailHandler;
        private IUserManager userManager;
        private IPetManager petManager;
        private IMessageManager messageManager;
        private Dictionary<string,string> emailCodeMap;

        private Random random;

        public Model(){
            tier2Mediator = new Tier2();
            emailHandler = new EmailHandler();
            random = new Random(1538);
            userManager = new UserManager(tier2Mediator);
            petManager = new PetManager(tier2Mediator);
            emailCodeMap = new Dictionary<string, string>();
            messageManager = new MessageController();
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
        public async Task<PetList> getPetsAsync(){
            
            PetList list = await petManager.requestPets();
            return list;
        }//to delete

        public async Task<IList<Pet>> getPetsAsync(AuthorisedUser user){
            IList<Pet> thePet = await petManager.requestPets(user);
            return thePet;
        }//to delete

        public async Task<IList<Pet>> getPetsAsync(int? id, string userEmail, string status){//TODO maybe move to PetManager
            if (id != null){ //TODO make full filtering
                Pet thePet = await petManager.requestPet((int)id);
                return new List<Pet>(){thePet};
            }
            if (!String.IsNullOrEmpty(userEmail)){
                if (await userManager.emailExist(userEmail)){
                    AuthorisedUser authUser = new AuthorisedUser() {email = userEmail};
                    return await petManager.requestPets(authUser);
                }
                return new List<Pet>();
            }
            if (!String.IsNullOrEmpty(status)){
                IList<Pet> petList = new List<Pet>();
                return petList;
            }
            return (await petManager.requestPets()).pets;
        }

        public async Task<Pet> createPetAsync(Pet pet,string token){
            string email = userManager.getUserWithToken(token);
            if (email == null){
                throw new AccessViolationException("user is not authorised");
            }
            pet.user.email = email;
            pet.user.name = (await userManager.GetUser(email)).name;
            Pet newPet = await petManager.createPet(pet);
            return newPet;
        }

        public async Task<Pet> deletePetAsync(Pet pet, string token){
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

        public async Task<Pet> updatePetAsync(Pet pet, string token){ // just owner can modify pet
            string email = userManager.getUserWithToken(token);
            if (email == null){
                throw new AccessViolationException("user is not authorised");
            }
            Pet databasePet = await petManager.requestPet(pet.id);
            if (databasePet.user.email != email){
                throw new AccessViolationException("just owner of pet can modify it.");
            }
            pet.user.email = email;
            pet.user.name = (await userManager.GetUser(email)).name;
            foreach (Status status in pet.statuses){
                status.pet = Pet.copy(pet);
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

        public async Task<AuthorisedUser> GetAuthorisedUser(string token){
            string email = userManager.getUserWithToken(token);
            if (email == null){
                return null;
            }
            AuthorisedUser user = await userManager.GetUser(email);
            return user;
        }
        public async Task<AuthorisedUser> register(User user){
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

        public async Task sendMessage(Message message, string token){
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await userManager.GetUser(email);
            int senderId = message.SenderPetId;
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((Pet pet) => {return pet.id == senderId;}).Count() > 0){
                messageManager.sendMessage(message);
            } else {
                throw new AccessViolationException("you are not owner of the pet.");
            }
        }
        public async Task<IList<Message>> GetMessages(int petId, string token){//make it authenticaitons
            string email = userManager.getUserWithToken(token);
            AuthorisedUser usr = await userManager.GetUser(email);
            //check if the user own the pet that he want to claim to send the message from
            if (usr.pets.Where((Pet pet) => {return pet.id == petId;}).Count() > 0){
                return messageManager.getMessages(petId);
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