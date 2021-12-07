using business_logic.Model.PetPack;
using System.Collections.Generic;

namespace business_logic.Model.MessagePack
{
    public interface IMessageManager
    {
        void sendMessage(Message message);
        IList<Message> getMessages(int identifier);
    }
}