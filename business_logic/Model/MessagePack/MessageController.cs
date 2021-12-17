using System.Collections.Generic;
using Entities;
using business_logic.Model.Mediator;
using System.Threading.Tasks;
using business_logic.Controllers;

namespace business_logic.Model.MessagePack
{
    public class MessageController : IMessageControl
    {
        private ITier2Message messageTier;
        private ITier2Pets tier2Pets;

        public MessageController(ITier2Message messageTier, ITier2Pets tier2Pets){
            this.messageTier = messageTier;
            this.tier2Pets = tier2Pets;
        }

        public async Task sendMessage(Message message, string token){
            await messageTier.addMessage(message);
        }
        public async Task<IList<Message>> GetMessages(int receiverId, int senderId, string token){
            List<Message> messageList = new List<Message>();
            messageList.AddRange(await messageTier.getAllOfMessage(receiverId,senderId));
            messageList.AddRange(await messageTier.getAllOfMessage(senderId,receiverId));
            return messageList;

        }

        public async Task<IList<Pet>> GetMessagePets(int receiverId, string token){
            IList<Message> messageList = await messageTier.getAllOfReceiverMessage(receiverId);
            List<Pet> petIds = new List<Pet>();
            foreach (Message mesg in messageList){
                petIds.Add(await tier2Pets.requestPet(mesg.SenderPetId));
            }
            return petIds;
        }
    }
}