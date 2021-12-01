using System.Threading.Tasks;
using ClientApp.Model;

namespace ClientApp.Data
{
    public interface IUserController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newUser"></param>
        /// <exception cref=""></exception>
        /// <returns></returns>
        Task<User> Register(User newUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        Task<User> Login(string email, string code);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task SendEmail(string email);
    }
}