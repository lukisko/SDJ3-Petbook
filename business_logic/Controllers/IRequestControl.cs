using System.Threading.Tasks;
using System.Collections.Generic;
using Entities;

namespace business_logic.Controllers
{
    public interface IRequestControl
    {
        Task<IList<User>> GetPetRequests(int receiverPetId, string token);
        Task<IList<Request>> GetRequests(int receiverPetId, string senderUserEmail, string token);
        Task sendRequest(Request request, string token);
    }
}