using System.Threading.Tasks;

namespace business_logic.Model.UserPack
{
    public interface IUserManager
    {
        Task<bool> emailExist(string email);
        Task<AuthorisedUser> GetUser(string email);
        Task<AuthorisedUser> CreateUser(AuthorisedUser user);
    }
}