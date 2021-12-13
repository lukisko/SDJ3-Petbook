using System;
using System.Threading.Tasks;
using Entities;
using System.Collections.Generic;

namespace business_logic.Controllers
{
    public interface IPetControl
    {
        Task<IList<Pet>> getPetsAsync(int? id, string userEmail, string status, 
        string type, string breed, char? gender, DateTime? birthday, string name);
        Task<Pet> createPetAsync(Pet pet, string token);
        Task<Pet> updatePetAsync(Pet pet, string token);
        Task<Pet> deletePetAsync(Pet pet, string token);
    }
}