using System.Threading.Tasks;
using business_logic.Model.UserPack;
using System.Collections.Generic;

namespace business_logic.Model
{
    public interface IModel
    {
        Task<PetList> getPetsAsync();   

        Task<IList<Pet>> getPetsAsync(AuthorisedUser user);
        /// <summary>
        /// get pets that will be also filtered by your criteria
        /// </summary>
        /// <param name="id">id that you want to filter by</param>
        /// <param name="userEmail">email of the owner of the pet you want to search by</param>
        /// <param name="status">status of pet you are looking for</param>
        /// <returns>list of pets that fullfil the criteria</returns>
        Task<IList<Pet>> getPetsAsync(int? id, string userEmail, string status);
        Task<Pet> deletePetAsync(Pet pet, string token);
        /// <summary>
        /// update a pet - provide a pet with some changes to have upto date info
        /// </summary>
        /// <param name="pet">the updated version of pet (for new statuses have id 0) if status not modified, do not change the id</param>
        /// <param name="token">access token that you got during login</param>
        /// <throws>throw access vialotion if you want to modify pet that you are not owner of</throws>
        /// <returns>the newly updated pet</returns>
        Task<Pet> updatePetAsync(Pet pet, string token);
        /// <summary>
        /// method to create a pet (user info is not needed)
        /// </summary>
        /// <param name="pet">the pet you want to create</param>
        /// <param name="token">access token that user got during login</param>
        /// <notes>if there is new city/country it will be created automatically</notes>
        /// <returns>the newly created pet</returns>
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
        /// <summary>
        /// get your username and list of your pets
        /// </summary>
        /// <param name="token">token that you have got during login</param>
        /// <returns>object of the user that was assigned this token</returns>
        Task<AuthorisedUser> GetAuthorisedUser(string token);
        /// <summary>
        /// method for new user to register to the system
        /// </summary>
        /// <param name="user">object with name and email that will be set in database</param>
        /// <returns>returns object </returns>
        Task<AuthorisedUser> register(User user);
    }
}