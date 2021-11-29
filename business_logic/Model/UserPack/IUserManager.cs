using System.Threading.Tasks;

namespace business_logic.Model.UserPack
{
    public interface IUserManager
    {
        Task<bool> emailExist(string email);
        Task<AuthorisedUser> GetUser(string email);
        Task<AuthorisedUser> CreateUser(AuthorisedUser user);
        string MakeUserCode(string email);
        bool IsCorrectCode(string email, string code);
        string MakeUserToken(string email);
        bool IsCorrectToken(string email, string token);
    }
}