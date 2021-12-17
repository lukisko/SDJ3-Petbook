using System.Threading.Tasks;
using business_logic.Model.UserPack;
using System;
using System.Collections.Generic;
using Entities;

namespace business_logic.Model.PetPack
{
    public interface IPetManager
    {
        Task<PetList> requestPets();
        Task<Pet> requestPet(int id);
        Task<IList<Pet>> requestPets(AuthorisedUser user);
        Task<IList<Entities.Pet>> getPetsAsync(int? id, string userEmail, string status, 
        string type, string breed, char? gender, DateTime? birthday, string name);
        Task<IList<Pet>> getPetsByStatus(string status);
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