using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Data
{
    public interface IRequestController
    {
        Task<IList<User>> GetAllReceivedRequestsAsync(int petId);
        
        Task<IList<Request>> GetAllRequestsAsync(string email, int petId);
        Task SendRequestAsync(Request request);

    }
}