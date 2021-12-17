using System.Threading.Tasks;
using Entities;
using System.Collections.Generic;

namespace business_logic.Model.Mediator
{
    public interface ITier2Pets
    {
        Task<PetList> requestPets();
        Task<IList<Pet>> GetByUserEmail(AuthorisedUser user);
        //Task<IList<Pet>> requestPetByStatus(string statusName);
        Task<Pet> requestPet(int id);
        Task<Pet> createPet(Pet newPet);
        Task<Pet> deletePet(Pet petToDelete);
        Task<Pet> updatePet(Pet petToUpdate);
    }
}