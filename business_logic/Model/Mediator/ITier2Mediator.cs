using System.Collections.Generic;
using System.Threading.Tasks;

namespace business_logic.Model.Mediator
{
    public interface ITier2Mediator
    {
        Task<PetList> requestPets();
        Task<Pet> createPet(Pet newPet);
    }

    
}