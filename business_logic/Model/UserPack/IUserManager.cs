using System.Threading.Tasks;

namespace business_logic.Model.UserPack
{
    public interface IUserManager
    {
        Task<bool> emailExist(string email);
        Task<User> GetUser(string email);
        Task<User> CreateUser(User user);
    }
}