using System.Collections.Generic;
using System;

namespace business_logic.Model.RequestPack
{
    public class RequestManager<T,V> :IRequestManager<T,V>
    {
        private Dictionary<int,IList<T>> dictionary;
        private Func<T,int> identifier;
        private Func<T,V> secondIdentifier;

        public RequestManager(Func<T,int> identifier, Func<T,V> secondIdentifier){//character U\200A is special white space "hair space"
            this.identifier = identifier;
            this.secondIdentifier = secondIdentifier;
            this.dictionary = new Dictionary<int, IList<T>>();
        }
        public IList<T> getRequestOfPetAndUser(int identifier, V secondIdentifier){
            List<T> returnValue = new List<T>();
            if(dictionary.ContainsKey(identifier)){
                IList<T> allMessages = dictionary[identifier];
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
        public IList<V> getRequestsOfPet(int petId){
            List<V> userEmails = new List<V>();
            if (dictionary.ContainsKey(petId)){
                foreach (T request in dictionary[petId]){
                    userEmails.Add(secondIdentifier(request));
                }
            }
            return userEmails;
        }
        public void makeRequest(T request){
            if (dictionary.ContainsKey(identifier(request))){
                dictionary[identifier(request)].Add(request);
            } else {
                dictionary[identifier(request)] = new List<T>(){request};
            }
        }
    }
}