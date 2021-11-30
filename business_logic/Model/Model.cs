using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using System.Collections.Generic;
using business_logic.Model.UserPack;

namespace business_logic.Model
{
    public class Model : IModel
    {
        private ITier2Mediator tier2Mediator;
        private IEmailHandler emailHandler;
        private IUserManager userManager;
        private Dictionary<string,string> emailCodeMap;

        private Random random;

        public Model(){
            tier2Mediator = new Tier2();
            emailHandler = new EmailHandler();
            random = new Random(1538);
            userManager = new UserManager(tier2Mediator);
            emailCodeMap = new Dictionary<string, string>();
        }
        //////change this down part
        public bool Login(string email){
            try {
                emailHandler.sendEmail(email,"Your login link - PetBook","Testing Hello there!");
            } catch (Exception exception){
                Console.WriteLine("error occured!"+exception);
                return false;
            }
            return true;
        }
        public async Task<PetList> getPetsAsync(){
            
            PetList list = await tier2Mediator.requestPets();
            return list;
        }

        public async Task<Pet> createPetAsync(Pet pet){
            Pet newPet = await tier2Mediator.createPet(pet);
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
        public async Task<User> register(User user){
            //change this
            AuthorisedUser authUsr = new AuthorisedUser(){
                email = user.email,
                name = user.name,
                pets = new Pet[0]
            };
            Console.WriteLine("something is here");
            await this.sendCode(user.email);
            User usr = await userManager.CreateUser(authUsr);
            Console.WriteLine("efter creating user");
            return usr;
        }

        private string createRandomCode(int codeLength){
            string code = "";
            for (int i = 0; i< codeLength;i++){
                char ch =(char)random.Next(65,90+1);
                code += ch.ToString();
            }
            return code;
        }

        public string getLoginToken(string email){
            return "01100110";
        }
    }
}