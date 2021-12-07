using System.Collections.Generic;
using business_logic.Model.PetPack;

namespace business_logic.Model.MessagePack
{
    public class MessageController : IMessageManager
    {
        private Dictionary<int,IList<Message>> dictionary;

        public MessageController(){
            dictionary = new Dictionary<int, IList<Message>>();
        }

        public void sendMessage(Message message){
            int identifier = message.ReceiverPetId;
            if (dictionary.ContainsKey(identifier)){
                dictionary[identifier].Add(message);
            } else {
                dictionary.Add(identifier,new List<Message>(){message});
            }
        }
        public IList<Message> getMessages(int identifier){
            if (dictionary.ContainsKey(identifier)){
                IList<Message> messages = dictionary[identifier];
                dictionary.Remove(identifier);
                return messages;
            } else {
                return new List<Message>(){};
            }
        }
    }
}