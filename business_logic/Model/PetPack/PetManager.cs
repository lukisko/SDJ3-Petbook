using System.Threading.Tasks;
using business_logic.Model.UserPack;
using System.Collections.Generic;
using business_logic.Model.Mediator;
using Entities;
using System;

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

        public async Task<IList<Pet>> getPetsByStatus(string status){
            return await tier2Mediator.requestPetsByStatus(status);
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

            if (newPet.statuses != null){
                foreach (Status status in newPet.statuses){
                    status.pet = newPet.copy();
                    await tier2Mediator.addStatus(status);
                }
            }

            newPet.city = theCity;
            Pet pet = await tier2Mediator.createPet(newPet);
            return pet;
        }
        public async Task<Pet> updatePet(Pet newPet){
            Pet oldPet = await tier2Mediator.requestPet(newPet.id);//you can not change id of pet
            if (oldPet == null){
                return null;
            }

            //checking if a new status is added, old one is updated or deleted
            List<Status> orderedNewStatus = this.orderStatusesByIdLowToHigh((List<Status>) newPet.statuses);
            List<Status> orderedOldStatus = this.orderStatusesByIdLowToHigh((List<Status>) oldPet.statuses);
            Console.WriteLine(orderedNewStatus);
            Console.WriteLine(orderedOldStatus);
            
            int oldLength = orderedOldStatus.Count;
            int notCheckedIndex = 0;
            foreach (Status newStatus in orderedNewStatus){
                newStatus.pet.id = newPet.id;
                if (notCheckedIndex>=oldLength){
                    await tier2Mediator.addStatus(newStatus);
                } else if (newStatus.id<orderedOldStatus[notCheckedIndex].id){
                    await tier2Mediator.addStatus(newStatus);
                } else if (newStatus.id == orderedOldStatus[notCheckedIndex].id){
                    //if the first value is not null and second value is not equal - update
                    //if the first one is null and the second one is not null - update
                    //*first == new; second == old

                    //update if both of them are not null AND (one of them is null OR they are different)
                    if ((!(newStatus.user == null && orderedOldStatus[notCheckedIndex].user == null)) && 
                        (
                            (newStatus.user == null ^ orderedOldStatus[notCheckedIndex].user == null) ||
                            !(newStatus.user.email.Equals(orderedOldStatus[notCheckedIndex].user.email))
                        ) ){
                        Status theStatus = await tier2Mediator.getStatus(newStatus);
                        User theUser = await tier2Mediator.GetUser(new AuthorisedUser(){email = newStatus.user.email});
                        theStatus.user = theUser;
                        await tier2Mediator.updateStatus(theStatus);
                    }
                    notCheckedIndex++;
                } else {
                    await tier2Mediator.removeStatus(orderedOldStatus[notCheckedIndex]);
                    notCheckedIndex++;
                }
            }

            while (notCheckedIndex < orderedOldStatus.Count){
                await tier2Mediator.removeStatus(orderedOldStatus[notCheckedIndex]);
                notCheckedIndex++;
            }

            if (newPet.city.country.name != oldPet.city.country.name){//if the pet is in new country or city, we need to check it
                Country newCountry = await tier2Mediator.GetCountry(newPet.city.country);
                if (newCountry == null){
                    newCountry = await tier2Mediator.AddCountry(newPet.city.country);
                }
                //check if the city needs to be added
                newPet.city.country = newCountry;
                City newCity = await tier2Mediator.GetCity(newPet.city);
                if (newCity == null){
                    newCity = await tier2Mediator.AddCity(newPet.city);
                }
                newPet.city = newCity;
            } else if (newPet.city.name != oldPet.city.name){
                City newCity = await tier2Mediator.GetCity(newPet.city);
                if (newCity == null){
                    newCity = await tier2Mediator.AddCity(newPet.city);
                }
                newPet.city = newCity;
            }
            return await tier2Mediator.updatePet(newPet);
        }
        public async Task<Pet> deletePet(Pet oldPet){
            foreach (Status status in oldPet.statuses){
                await tier2Mediator.removeStatus(status);
            }
            return await tier2Mediator.deletePet(oldPet);
        }

        private List<Status> orderStatusesByIdLowToHigh(List<Status> list){
            int length = list.Count;
            if (length < 3){
                if (length < 2){
                    return list;
                }
                if (list[0].id>list[1].id){
                    return new List<Status>(){list[1],list[0]};
                }
                return list;
            }
            //making quicksort
            List<Status> lowerOrEqualValue = new List<Status>();
            List<Status> higerValue = new List<Status>();
            List<Status> returnValue = new List<Status>(length);

            Status pivot = list[0];
            list.Remove(pivot);

            foreach (Status status in list){
                if (status.id> pivot.id){
                    higerValue.Add(status);
                } else {
                    lowerOrEqualValue.Add(status);
                }
            }

            returnValue.AddRange(this.orderStatusesByIdLowToHigh(lowerOrEqualValue));
            returnValue.Add(pivot);
            returnValue.AddRange(this.orderStatusesByIdLowToHigh(higerValue));

            return returnValue;
        }
    }
}