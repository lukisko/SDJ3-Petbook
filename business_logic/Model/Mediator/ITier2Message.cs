using Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace business_logic.Model.Mediator
{
    public interface ITier2Message
    {
        Task<Message> getMessage(Message messg);
        Task<IList<Message>> getAllOfMessage(Message messg);
        Task<IList<Message>> getAllOfReceiverMessage(Message messg);
        Task<Message> addMessage(Message messg);
        Task<Message> removeMessage(Message messg);
    }
}