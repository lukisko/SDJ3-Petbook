#nullable enable
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
        Task<Pet> AddPetAsync(Pet pet);

        /// <summary>
        /// 
        /// </summary>
        /// <returns> IList with all pets account</returns>
        Task<IList<Pet>> GetAllPetsAsync();
        

         Task<IList<Pet>> GetAllUserPetsAsync();
         
         Task<Pet> GetPetProfileAsync(int petId);

         Task<Pet> UpdatePetAsync(Pet pet);
        
         Task DeletePetAsync(int petId);


         // Task AdoptPetAsync(string userEmail, int petId);
         // Task FosterPetAsync(string userEmail, int petId);
         // Task WalkPetAsync(string userEmail, int petId);
    }
}