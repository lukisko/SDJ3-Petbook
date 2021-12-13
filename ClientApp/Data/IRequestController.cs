using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Data
{
    public interface IRequestController
    {
        Task<IList<Request>> GetAllRequestsAsync(string? userId, int petId);
        Task SendRequestAsync(Request request);

    }
}