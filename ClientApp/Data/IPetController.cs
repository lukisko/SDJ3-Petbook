using System;
using System.Threading.Tasks;
using business_logic.Model;
using System.Collections.Generic;
using business_logic.Model;

namespace ClientApp.Data
{
    public interface IPetController
    {
        Task addPetAsync(Pet pet);
        Task<IList<Pet>> GetAllPetsAsync();
    }
}