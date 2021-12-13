using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;

namespace ClientApp.Data
{
    public interface IMessageController
    {
       Task SendMessageAsync(Message message);
      Task<IList<Message>> GetAllMessagesAsync(int receiverPetId,int senderPetId);
     // Task<IList<Message>> GetAllMessageLog(int petId);
     Task<IList<Pet>> GetAllMessagePets(int loggedInPet);


    }
}