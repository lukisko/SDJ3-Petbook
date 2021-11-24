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

        private static readonly int codeLength = 7;

        public Model(){
            tier2Mediator = new Tier2();
            emailHandler = new EmailHandler();
            random = new Random(1538);
            userManager = new UserManager(tier2Mediator);
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
        //TODO make REST connect to model and model to socket

        public async Task<bool> sendCode(string email){
            if (! await userManager.emailExist(email)){
                return false;
            }
            string code = this.createRandomCode();
            emailHandler.sendLoginLink(email,code);
            emailCodeMap[email]=code;
            return true;
        }
        public async Task<User> login(string email, string code){
            if (!emailCodeMap.ContainsKey(email)){
                return new User();
            }
            if (emailCodeMap[email]==code){
                return await userManager.GetUser(email);
            }
            return new User();
        }
        public async Task<User> register(User user){
            await this.sendCode(user.email);
            User usr = await tier2Mediator.MakeUser(user);
            return usr;
        }

        private string createRandomCode(){
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