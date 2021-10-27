using System;
using System.Threading.Tasks;

namespace ClientApp.Data
{
    public interface IPetController
    {
        Task addPetAsync(Pet pet);
        Task<IList<Pet>> GetAllPetsAsync();
    }
}