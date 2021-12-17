using Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace business_logic.Model.Mediator
{
    public interface ITier2Message
    {
        Task<Message> getMessage(Message messg);
        Task<IList<Message>> getAllOfMessage(int receiverId, int senderId);
        Task<IList<Message>> getAllOfReceiverMessage(int receiverId);
        Task<IList<Message>> getAllOfSenderMessage(int senderId);
        Task<Message> addMessage(Message messg);
        Task<Message> removeMessage(Message messg);
    }
}