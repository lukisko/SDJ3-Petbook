using System.Threading.Tasks;
using System.Collections.Generic;
using ClientApp.Model;
using Entities;

namespace business_logic.Controllers
{
    public interface IMessageControl
    {
        Task sendMessage(Message message, string token);
        Task<IList<Message>> GetMessages(int receiverPetId, int senderPetId, string token);
        Task<IList<Pet>> GetMessagePets(int receiverPetId, string token);
    }
}