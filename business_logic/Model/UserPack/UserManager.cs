using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using business_logic.Model.UserPack;
using business_logic.Model;

namespace business_logic.Model.UserPack
{
    public class UserManager : IUserManager
    {
        private ITier2Mediator tier2Mediator;
        private Dictionary<string,AuthorisedUser> emailUserMap;
        private Dictionary<string,string> emailCodeMap;
        private Dictionary<string,string> tokenEmailMap;

        private Random random;

        public UserManager(ITier2Mediator mediator){
            this.tier2Mediator = mediator;
            emailUserMap = new Dictionary<string, AuthorisedUser>();
            random = new Random(1538);
            emailCodeMap = new Dictionary<string, string>();
            tokenEmailMap = new Dictionary<string, string>();
        }

        public async Task<bool> emailExist(string email){
            AuthorisedUser usr = new AuthorisedUser(){email = email, pets = new Pet[0]};
            AuthorisedUser realUser = await tier2Mediator.GetUser(usr);
            if (realUser == null || String.IsNullOrEmpty(realUser.email)){
                return false;
            }
            emailUserMap[email] = realUser;
            return true;
        }

        public async Task<AuthorisedUser> GetUser(string email){
            if (emailUserMap.ContainsKey(email)){
                return emailUserMap[email];
            } else {
                AuthorisedUser usr = new AuthorisedUser(){email = email};
                AuthorisedUser realUser = await tier2Mediator.GetUser(usr);
                return realUser;
            }
        }

        public async Task<AuthorisedUser> CreateUser(AuthorisedUser user){
            AuthorisedUser usr = await tier2Mediator.MakeUser(user);
            return usr;
        }

        public string MakeUserCode(string email){
            string code = this.createRandomCode(7);
            emailCodeMap[email] = code;
            return code;
        }

        public bool IsCorrectCode(string email, string code){
            if (emailCodeMap.ContainsKey(email)){
                if (emailCodeMap[email].Equals(code)){
                    return true;
                }
            }
            return false;
        }

        public string MakeUserToken(string email){
            string token = this.createRandomCode(25);
            tokenEmailMap[token] = email;
            return token;
        }

        public bool IsCorrectToken(string email, string token){
            if (emailCodeMap.ContainsKey(email)){
                if (emailCodeMap[email].Equals(token)){
                    return true;
                }
            }
            return false;
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