using System.Threading.Tasks;

namespace business_logic.Model
{
    public interface IModel
    {
        bool Login(string email);
        Task<PetList> getPetsAsync();
        Task<Pet> createPetAsync(Pet pet);
    }
}