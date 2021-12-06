using System.Threading.Tasks;
using business_logic.Model.UserPack;
using System.Collections.Generic;

namespace business_logic.Model.PetPack
{
    public interface IPetManager
    {
        Task<PetList> requestPets();
        Task<Pet> requestPet(int id);
        Task<IList<Pet>> requestPets(AuthorisedUser user);
        Task<Pet> createPet(Pet newPet);
        Task<Pet> updatePet(Pet newPet);
        Task<Pet> deletePet(Pet oldPet);
    }
}