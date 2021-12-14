using System.Collections.Generic;
using Entities;
using business_logic.Model.Mediator;
using System.Threading.Tasks;

namespace business_logic.Model.MessagePack
{
    public class MessageController : IMessageManager
    {
        private Dictionary<int,IList<Message>> dictionary;
        private ITier2Message messageTier;

        public MessageController(ITier2Message messageTier){
            this.messageTier = messageTier;
            dictionary = new Dictionary<int, IList<Message>>();
        }

        public void sendMessage(Message message){
            messageTier.addMessage(message);
        }
        public async Task<IList<Message>> getMessages(int receiverId, int senderId){
            return await messageTier.getAllOfMessage(receiverId,senderId);
        }

        public async Task<IList<int>> getPetIdOfMessages(int receiverId){
            IList<Message> messageList = await messageTier.getAllOfReceiverMessage(receiverId);
            List<int> petIds = new List<int>();
            foreach (Message mesg in messageList){
                petIds.Add(mesg.SenderPetId);
            }
            return petIds;
        }
    }
}