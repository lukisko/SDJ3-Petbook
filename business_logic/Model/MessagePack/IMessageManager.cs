using business_logic.Model.PetPack;
using System.Collections.Generic;
using Entities;
using System.Threading.Tasks;

namespace business_logic.Model.MessagePack
{
    public interface IMessageManager
    {
        void sendMessage(Message message);
        Task<IList<Message>> getMessages(int receiverId, int senderId);
        Task<IList<Pet>> getPetIdOfMessages(int receiverId);
    }
}