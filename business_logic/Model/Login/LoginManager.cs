using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;
using Entities;
using Microsoft.AspNetCore.Components;
using business_logic.Model.Login;
using business_logic.Controllers;

namespace business_logic.Model
{
    public class LoginManager : ILoginManager
    {
        private Dictionary<string,string> emailCodeMap;
        private Dictionary<string,string> tokenEmailMap;
        private IEmailHandler emailHandler;
        private Random random;

        public LoginManager(IEmailHandler emailHandler){
            this.emailHandler = emailHandler;
            random = new Random(1538);
            emailCodeMap = new Dictionary<string, string>();
            tokenEmailMap = new Dictionary<string, string>();
        }

        public void MakeUserCode(string email){
            string code = this.createRandomCode(7);
            emailCodeMap[email] = code;
            emailHandler.sendLoginLink(email,code);
            Console.WriteLine("email is no its way with code: "+code);
        }

        public bool IsCorrectCode(string email, string code){
            if (emailCodeMap.ContainsKey(email)){
                if (emailCodeMap[email].Equals(code)){
                    emailCodeMap.Remove(email);
                    return true;
                }
            }
            return false;
        }

        public string MakeUserToken(string email){
            string token = "";
            do {
                token = this.createRandomCode(25);
            }while (tokenEmailMap.ContainsKey(token));
            tokenEmailMap[token] = email;
            return token;
        }

        public string getUserWithToken(string token){
            if (!tokenEmailMap.ContainsKey(token)){
                return null;
            }
            return tokenEmailMap[token];
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