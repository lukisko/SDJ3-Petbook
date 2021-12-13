using business_logic.Model.PetPack;
using System.Collections.Generic;
using Entities;

namespace business_logic.Model.MessagePack
{
    public interface IMessageManager
    {
        void sendMessage(Message message);
        IList<Message> getMessages(int receiverId, int senderId);
        IList<int> getPetIdOfMessages(int receiverId);
    }
}