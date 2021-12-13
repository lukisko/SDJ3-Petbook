using System.Threading.Tasks;

namespace business_logic.Controllers
{
    public interface IAuthorisedUserControl
    {
        Task<Entities.AuthorisedUser> GetAuthorisedUser(string token);
    }
}