using System.Threading.Tasks;
using business_logic.Model.UserPack;
using System.Collections.Generic;
using business_logic.Model.Mediator;

namespace business_logic.Model.PetPack
{
    public class PetManager : IPetManager
    {
        private ITier2Mediator tier2Mediator;

        public PetManager(ITier2Mediator mediator){
            this.tier2Mediator = mediator;
        }
        public async Task<PetList> requestPets(){
            return await tier2Mediator.requestPets();
        }
        public async Task<Pet> requestPet(int id){
            return await tier2Mediator.requestPet(id);
        }
        public async Task<IList<Pet>> requestPets(AuthorisedUser user){
            return await tier2Mediator.requestPets(user);
        }
        public async Task<Pet> createPet(Pet newPet){//TODO check if the user, city and country exist
            Country theCountry = await tier2Mediator.GetCountry(newPet.city.country);
            if (theCountry == null){
                theCountry = await tier2Mediator.AddCountry(newPet.city.country);
            }
            
            City city = newPet.city;
            city.country = theCountry;

            City theCity = await tier2Mediator.GetCity(city);
            if (theCity == null){
                theCity = await tier2Mediator.AddCity(city);
            }

            newPet.city = theCity;
            Pet pet = await tier2Mediator.createPet(newPet);
            return pet;
        }
        public async Task<Pet> updatePet(Pet newPet){
            return await tier2Mediator.updatePet(newPet);
        }
        public async Task<Pet> deletePet(Pet oldPet){
            return await tier2Mediator.deletePet(oldPet);
        }
    }
}