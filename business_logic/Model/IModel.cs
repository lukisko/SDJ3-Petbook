using System.Threading.Tasks;
using business_logic.Model.UserPack;

namespace business_logic.Model
{
    public interface IModel
    {
        Task<PetList> getPetsAsync();
        Task<Pet> createPetAsync(Pet pet, string token);
        /// <summary>
        /// method to send one time login code to user
        /// </summary>
        /// <param name="email">email address of user that requested login.</param>
        /// <returns>returns true if the email exists and email was send, and false if the email do not exist.</returns>
        Task<bool> sendCode(string email);
        /// <summary>
        /// method to login enter user email and the code that he claim he received
        /// </summary>
        /// <param name="email">emial of user that want to log in</param>
        /// <param name="code">code that we have send to his/her email</param>
        /// <returns>if code and email are good return access token, returns empty string otherwise</returns>
        Task<string> login(string email, string code); // is it going to be user or email??
        Task<AuthorisedUser> register(User user);
    }
}