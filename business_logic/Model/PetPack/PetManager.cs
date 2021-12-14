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
        private ITier2Pets tier2Pet;
        private ITier2City tier2City;
        private ITier2Country tier2Country;
        private ITier2Status tier2Status;
        private ITier2User tier2User;

        public PetManager(ITier2Pets mediator, ITier2City tier2City, ITier2Country tier2Country,ITier2Status tier2Status,ITier2User tier2User){
            this.tier2Pet = mediator; // change name if this
            this.tier2City = tier2City;
            this.tier2Country = tier2Country;
            this.tier2Status = tier2Status;
            this.tier2User = tier2User;
        }
        public async Task<PetList> requestPets(){
            PetList list = await tier2Pet.requestPets();
            Console.WriteLine("have got all pets");
            foreach (Pet pet in list.pets){
                Console.WriteLine("getting status of pets");
                pet.statuses = await tier2Status.getStatusesOf(pet);
            }
            return list;
        }
        public async Task<Pet> requestPet(int id){
            Pet pet = await tier2Pet.requestPet(id);
            pet.statuses = await tier2Status.getStatusesOf(pet);
            return pet;
        }
        public async Task<IList<Pet>> requestPets(AuthorisedUser user){
            return await tier2Pet.GetByUserEmail(user);
        }

        public async Task<IList<Pet>> getPetsByStatus(string status){
            IList<Status> rightStatuses = await tier2Status.requestStatusByName(status);
            List<Pet> returnPets = new List<Pet>();
            foreach (Status tmpStatus in rightStatuses){
                Pet tmpPet = tmpStatus.pet;
                tmpPet.statuses = new List<Status>(){tmpStatus.copy()};
                returnPets.Add(tmpStatus.pet);
            }
            return returnPets;
        }
        public async Task<Pet> createPet(Pet newPet){//TODO check if the user, city and country exist
            Country theCountry = await tier2Country.getCountry(newPet.city.country);
            if (theCountry == null){
                theCountry = await tier2Country.addCountry(newPet.city.country);
            }
            
            City city = newPet.city;
            city.country = theCountry;

            City theCity = await tier2City.getCity(city);
            if (theCity == null){
                theCity = await tier2City.addCity(city);
            }

            if (newPet.statuses != null){
                foreach (Status status in newPet.statuses){
                    status.pet = newPet.copy();
                    await tier2Status.addStatus(status);
                }
            }

            newPet.city = theCity;
            Pet pet = await tier2Pet.createPet(newPet);
            return pet;
        }
        public async Task<Pet> updatePet(Pet newPet){
            Pet oldPet = await tier2Pet.requestPet(newPet.id);//you can not change id of pet
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
                    await tier2Status.addStatus(newStatus);
                } else if (newStatus.id<orderedOldStatus[notCheckedIndex].id){
                    await tier2Status.addStatus(newStatus);
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
                        Status theStatus = await tier2Status.getStatus(newStatus);
                        User theUser = await tier2User.GetUser(new AuthorisedUser(){email = newStatus.user.email});
                        theStatus.user = theUser;
                        await tier2Status.updateStatus(theStatus);
                    }
                    notCheckedIndex++;
                } else {
                    await tier2Status.removeStatus(orderedOldStatus[notCheckedIndex]);
                    notCheckedIndex++;
                }
            }

            while (notCheckedIndex < orderedOldStatus.Count){
                await tier2Status.removeStatus(orderedOldStatus[notCheckedIndex]);
                notCheckedIndex++;
            }

            if (newPet.city.country.name != oldPet.city.country.name){//if the pet is in new country or city, we need to check it
                Country newCountry = await tier2Country.getCountry(newPet.city.country);
                if (newCountry == null){
                    newCountry = await tier2Country.addCountry(newPet.city.country);
                }
                //check if the city needs to be added
                newPet.city.country = newCountry;
                City newCity = await tier2City.getCity(newPet.city);
                if (newCity == null){
                    newCity = await tier2City.addCity(newPet.city);
                }
                newPet.city = newCity;
            } else if (newPet.city.name != oldPet.city.name){
                City newCity = await tier2City.getCity(newPet.city);
                if (newCity == null){
                    newCity = await tier2City.addCity(newPet.city);
                }
                newPet.city = newCity;
            }
            return await tier2Pet.updatePet(newPet);
        }
        public async Task<Pet> deletePet(Pet oldPet){
            foreach (Status status in oldPet.statuses){
                await tier2Status.removeStatus(status);
            }
            return await tier2Pet.deletePet(oldPet);
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