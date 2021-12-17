using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using Entities;
using Microsoft.AspNetCore.Components;
using business_logic.Controllers;
using business_logic.Model.Login;


namespace business_logic.Model.UserPack
{
    public class UserManager : IUserControl,IUserManager//, IAuthorisedUserControl
    {
        private ITier2User tier2Mediator;
        private ILoginManager loginManager;
        private Dictionary<string,AuthorisedUser> emailUserMap;

        public UserManager(ITier2User tier2User,ILoginManager loginManager){
            this.tier2Mediator = tier2User;
            this.loginManager = loginManager;
            emailUserMap = new Dictionary<string, AuthorisedUser>();
        }

        public async Task<bool> sendCode(string email){
            if (! await this.emailExist(email)){
                return false;
            }
            loginManager.MakeUserCode(email);
            
            return true;
        }

        /*public async Task<Entities.AuthorisedUser> GetAuthorisedUser(string token){
            string email = loginManager.getUserWithToken(token);
            if (email == null){
                return null;
            }
            AuthorisedUser user = await this.GetUser(email);
            user.pets = (await this.getPetsAsync(null,user.email,null,null,null,null,null,null)).ToArray();
            return user;
        }*/

        public async Task<Entities.AuthorisedUser> register(Entities.User user){
            //change this
            AuthorisedUser authUsr = new AuthorisedUser(){
                email = user.email,
                name = user.name,
                pets = new Pet[0]
            };
            //Console.WriteLine("something is here");
            if (! await this.emailExist(user.email)){
                AuthorisedUser usr = await this.CreateUser(authUsr);
                //await this.sendCode(user.email);
                Console.WriteLine("efter creating user");
                return usr;
            }
            throw new Exception("email already exist.");
        }

        public async Task<string> login(string email, string code){
            if (loginManager.IsCorrectCode(email,code)){
                return loginManager.MakeUserToken(email);
            }
            return "";
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