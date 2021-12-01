using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;

namespace ClientApp.Data
{
    public interface IMessageController
    {
       Task SendMessageAsync(Message message);
      Task<IList<Message>> GetAllMessagesWithAUserAsync(int receiverPetId);
      
    }
}