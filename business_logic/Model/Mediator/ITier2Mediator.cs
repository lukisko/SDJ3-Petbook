using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.UserPack;

namespace business_logic.Model.Mediator
{
    public interface ITier2Mediator
    {
        Task<PetList> requestPets();
        Task<Pet> requestPet(int id);
        Task<IList<Pet>> requestPets(AuthorisedUser user);
        Task<Pet> createPet(Pet newPet);
        Task<Pet> updatePet(Pet newPet);
        Task<Pet> deletePet(Pet oldPet);

        Task<AuthorisedUser> GetUser(AuthorisedUser user);
        Task<AuthorisedUser> MakeUser(AuthorisedUser user);
    }

    
}