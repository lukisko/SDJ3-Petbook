using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using business_logic.Model.UserPack;

namespace business_logic.Model.UserPack
{
    public class UserManager : IUserManager
    {
        private ITier2Mediator tier2Mediator;
        private Dictionary<string,User> emailUserMap;

        public UserManager(ITier2Mediator mediator){
            this.tier2Mediator = mediator;
        }

        public async Task<bool> emailExist(string email){
            User usr = new User(){email = email};
            User realUser = await tier2Mediator.GetUser(usr);
            if (String.IsNullOrEmpty(realUser.email)){
                return false;
            }
            emailUserMap[email] = realUser;
            return true;
        }

        public async Task<User> GetUser(string email){
            if (emailUserMap.ContainsKey(email)){
                return emailUserMap[email];
            } else {
                User usr = new User(){email = email};
                User realUser = await tier2Mediator.GetUser(usr);
                return realUser;
            }
        }

        public async Task<User> CreateUser(User user){
            User usr = await tier2Mediator.MakeUser(user);
            return usr;
        }
    }
}