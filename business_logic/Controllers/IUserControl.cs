using System.Threading.Tasks;
using Entities;

namespace business_logic.Controllers
{
    public interface IUserControl
    {
        Task<string> login(string email, string code);
        Task<AuthorisedUser> register(User user);
        Task<AuthorisedUser> GetUser(string email);
        Task<bool> sendCode(string email);
    }
}