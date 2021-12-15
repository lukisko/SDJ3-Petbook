using System.Collections.Generic;
using System;
using business_logic.Controllers;
using Entities;
using System.Threading.Tasks;
using business_logic.Model.Login;
using business_logic.Model.UserPack;
using business_logic.Model.Mediator;
using System.Linq;

namespace business_logic.Model.RequestPack
{
    public class RequestManager :/*IRequestManager<Request,string>,*/IRequestControl
    {
        private Dictionary<int,IList<Request>> dictionary;
        private Func<Request,int> identifier = new Func<Request, int>((request)=> {return request.petId;});
        private Func<Request,string> secondIdentifier = new Func<Request, string>((request)=> {return request.userEmail;});
        private ILoginManager loginManager;
        private ITier2User tier2User;
        private ITier2Pets tier2Pets;

        public RequestManager(ILoginManager loginManager,ITier2User userControl, ITier2Pets tier2Pets){//character U\200A is special white space "hair space"
            this.loginManager = loginManager;
            this.tier2User = userControl;
            this.tier2Pets = tier2Pets;
            this.dictionary = new Dictionary<int, IList<Request>>();
        }
        public async Task<IList<Request>> GetRequests(int identifier, string secondIdentifier,string token){
            string email = loginManager.getUserWithToken(token);
            IList<Pet> userPets = await tier2Pets.GetByUserEmail(new AuthorisedUser(){email = email});

            if (userPets.Where((thePet)=>{return thePet.id == identifier;}).Count() == 0){
                throw new AccessViolationException("you are not owner of the pet.");
            }
            List<Request> returnValue = new List<Request>();
            if(dictionary.ContainsKey(identifier)){
                IList<Request> allMessages = dictionary[identifier];
                int length = allMessages.Count;
                for (int i = allMessages.Count-1; i>=0;i--){
                    if (this.secondIdentifier(allMessages[i]).Equals(secondIdentifier)){
                        returnValue.Add(allMessages[i]);
                        allMessages.RemoveAt(i);
                    }
                }
            }
            return returnValue;
        }
        public async Task<IList<User>> GetPetRequests(int petId,string token){
            string email = loginManager.getUserWithToken(token);
            IList<Pet> petList = await tier2Pets.GetByUserEmail(new AuthorisedUser(){email = email});
            if (!(petList.Where((Pet pet) => {return pet.id == petId;}).Count() > 0)){
                throw new AccessViolationException("you are not owner of the pet.");
            }

            List<string> userEmails = new List<string>();
            if (dictionary.ContainsKey(petId)){
                foreach (Request request in dictionary[petId]){
                    userEmails.Add(secondIdentifier(request));
                }
            }
            IList<string> emails = userEmails;
            IList<User> returnValue = new List<User>();
                foreach (string theEmail in emails){
                    User theUser = await tier2User.GetUser(new AuthorisedUser(){email=email});
                    if (theUser != null && string.IsNullOrEmpty(theUser.email)){
                        returnValue.Add(theUser);
                    }
                } 
            return returnValue;
        }
        public async Task sendRequest(Request request,string token){
            string email = loginManager.getUserWithToken(token);
            
            if (email == null){
                return;
            }
            string senderId = request.userEmail;
            //check if the user own the pet that he want to claim to send the message from
            if (email != request.userEmail){
                throw new AccessViolationException("you are not authorised.");
            }
            if (dictionary.ContainsKey(identifier(request))){
                dictionary[identifier(request)].Add(request);
            } else {
                dictionary[identifier(request)] = new List<Request>(){request};
            }
        }
    }
}