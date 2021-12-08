using System.Collections.Generic;
using business_logic.Model.PetPack;
using System;
using System.Linq;

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
        public IList<Message> getMessages(int receiverId, int senderId){
            if (dictionary.ContainsKey(receiverId)){
                IList<Message> messages = dictionary[receiverId];
                IList<Message> returnMessages = new List<Message>();
                foreach (Message messg in messages){
                    if (messg.SenderPetId == senderId){
                        returnMessages.Add(messg);
                        messages.Remove(messg);
                    }
                }
                return returnMessages;
            } else {
                return new List<Message>(){};
            }
        }

        public IList<int> getPetIdOfMessages(int receiverId){
            throw new NotImplementedException("not implemented sorry");
        }
    }
}