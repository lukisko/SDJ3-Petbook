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
        /// <summary>
        /// method that is supposed to update a pet. you can not update id of the pet
        /// owner can not be also walker or foster
        /// </summary>
        /// <param name="newPet">the updated version of the pet</param>
        /// <returns>if succesfully updates pet return the new pet, returns null otherwise</returns>
        Task<Pet> updatePet(Pet newPet);
        Task<Pet> deletePet(Pet oldPet);
    }
}