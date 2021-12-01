using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.UserPack;

namespace business_logic.Model.Mediator
{
    public interface ITier2Mediator
    {
        Task<PetList> requestPets();
        Task<Pet> requestPet(int id);
        Task<Pet> createPet(Pet newPet);

        Task<AuthorisedUser> GetUser(AuthorisedUser user);
        Task<AuthorisedUser> MakeUser(AuthorisedUser user);
    }

    
}