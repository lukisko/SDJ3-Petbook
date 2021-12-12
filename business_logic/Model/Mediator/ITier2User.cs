using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.Mediator
{
    public interface ITier2User
    {
        Task<AuthorisedUser> GetUser(AuthorisedUser user);
        Task<AuthorisedUser> MakeUser(AuthorisedUser user);
    }
}