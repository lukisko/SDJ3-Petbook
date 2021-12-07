using System.Collections.Generic;
using System.Threading.Tasks;
using business_logic.Model.UserPack;

namespace business_logic.Model.Mediator
{
    public interface ITier2Mediator
    {
        Task<PetList> requestPets();
        Task<Pet> requestPet(int id);
        Task<IList<Pet>> requestPets(AuthorisedUser user);
        Task<Pet> createPet(Pet newPet);
        Task<Pet> updatePet(Pet newPet);
        Task<Pet> deletePet(Pet oldPet);

        Task<Status> getStatus(Status status);
        Task<Status> addStatus(Status newStatus);
        Task<Status> updateStatus(Status newerStatus);
        Task<Status> removeStatus(Status oldStatus);

        Task<City> GetCity(City city);
        Task<City> AddCity(City city);
        Task<Country> GetCountry(Country country);
        Task<Country> AddCountry(Country country);

        Task<AuthorisedUser> GetUser(AuthorisedUser user);
        Task<AuthorisedUser> MakeUser(AuthorisedUser user);
    }

    
}