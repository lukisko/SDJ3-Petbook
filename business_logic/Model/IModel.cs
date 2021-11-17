using System.Threading.Tasks;

namespace business_logic.Model
{
    public interface IModel
    {
        Task<PetList> getPetsAsync();
        Task<Pet> createPetAsync(Pet pet);

        ///<returns> returns true if the email exists and email was send, and false if the email do not exist.</returns>
        Task<bool> sendCode(string email);
        Task<User> login(string email, string code); // is it going to be user or email??
        Task<User> register(User user);
    }
}