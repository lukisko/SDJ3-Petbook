using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using ClientApp.Model;

namespace ClientApp.Data
{
    public interface IPetController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pet"></param>
        /// <returns></returns>
        Task AddPetAsync(Pet pet);

        /// <summary>
        /// 
        /// </summary>
        /// <returns> IList with all pets account</returns>
        Task<IList<Pet>> GetAllPetsAsync(int? id,string email,string status);

        // Task<IList<Pet>> GetAllUserPetsAsync(string userEmail);
        // Task UpdatePet(Pet pet);
        // Task DeletePet(int petId);
 
        
        // Task AdoptPetAsync(string userEmail, int petId);
        // Task FosterPetAsync(string userEmail, int petId);
        // Task WalkPetAsync(string userEmail, int petId);
    }
}