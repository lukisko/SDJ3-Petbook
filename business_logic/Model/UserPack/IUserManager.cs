using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.UserPack
{
    public interface IUserManager
    {
        /// <summary>
        /// check if user with specific email exist
        /// </summary>
        /// <param name="email">email of the user</param>
        /// <returns>task that has bool and represents if the user exist</returns>
        Task<bool> emailExist(string email);

        /// <summary>
        /// get a user with some specific email address
        /// </summary>
        /// <param name="email">email of the user we are looking for</param>
        /// <returns>return class of aauthorised user</returns>
        Task<AuthorisedUser> GetUser(string email);

        /// <summary>
        /// create an user
        /// </summary>
        /// <param name="user">Authorised user class that should be added to database</param>
        /// <returns>created class of the authorised user</returns>
        Task<AuthorisedUser> CreateUser(AuthorisedUser user);
        string MakeUserCode(string email);
        bool IsCorrectCode(string email, string code);
        string MakeUserToken(string email);
        string getUserWithToken(string token);
    }
}