using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace business_logic.Model
{
    public interface IPetsData
    {
         IList<Pet> GetPets();
         Pet AddPet(Pet pet);
         //Pet GetPet(int id);
         //void RemoveId(int petId);
         //Task<IList<Pet>> GetPetsAsync();
         //Task<IList<Pet>> GetPetsWhere(Func<Todo,bool> filter);
    }
}