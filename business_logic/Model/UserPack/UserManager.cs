using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using Entities;
using Microsoft.AspNetCore.Components;


namespace business_logic.Model.UserPack
{
    public class UserManager : IUserManager
    {
        private ITier2User tier2Mediator;
        private Dictionary<string,AuthorisedUser> emailUserMap;

        public UserManager(ITier2User tier2User){
            this.tier2Mediator = tier2User;
            emailUserMap = new Dictionary<string, AuthorisedUser>();
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
            AuthorisedUser usr = new AuthorisedUser(){email = email};
            AuthorisedUser realUser = await tier2Mediator.GetUser(usr);
            return realUser;
            /*if (emailUserMap.ContainsKey(email)){
                return emailUserMap[email];
            } else {
                AuthorisedUser usr = new AuthorisedUser(){email = email};
                AuthorisedUser realUser = await tier2Mediator.GetUser(usr);
                return realUser;
            }*/
        }

        public async Task<AuthorisedUser> CreateUser(AuthorisedUser user){
            AuthorisedUser usr = await tier2Mediator.MakeUser(user);
            return usr;
        }
    }
}