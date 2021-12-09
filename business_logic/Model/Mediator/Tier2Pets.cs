using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using business_logic.Model.UserPack;

namespace business_logic.Model.Mediator
{
    public class Tier2Pets
    {
        private Tier2 tier2;
        private static string theType = "pet";
        public Tier2Pets(Tier2 tier2){
            this.tier2 = tier2;
        }

        public async Task<PetList> requestPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>(theType,"GetAll",new Pet(){type="test",breed="ing",name="none"});

            Comunication<IList<Pet>> Pets = await tier2.requestServerAsync<Comunication<Pet>,Comunication<IList<Pet>>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(Pets));
            PetList petList = new PetList(){pets=Pets.value};
            return petList;
        }

        public async Task<IList<Pet>> GetByUserEmail(AuthorisedUser user){//TODO
            Console.WriteLine("name before serialize: "+ user.name);
            Comunication<AuthorisedUser> commClass = new Comunication<AuthorisedUser>("user","GetAllOf",user);

            Comunication<IList<Pet>> theUser = await tier2.requestServerAsync<Comunication<AuthorisedUser>,Comunication<IList<Pet>>>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(theUser));
            return theUser.value;//TODO should I get pet or comunication pet???
        }

        public async Task<IList<Pet>> requestPetByStatus(string statusName){
            Comunication<Status> communicationClass = new Comunication<Status>("status","GetAllOf",new Status(){name = statusName});

            Comunication<IList<Pet>> pets = await tier2.requestServerAsync<Comunication<Status>,Comunication<IList<Pet>>>(communicationClass);

            return pets.value;
        }/*

        public async Task<PetList> requestWalkingPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>("adoptionPet","GetAll",new Pet(){type="test",breed="ing",name="none"});

            Comunication<IList<Pet>> Pets = await tier2.requestServerAsync<Comunication<Pet>,Comunication<IList<Pet>>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(Pets));
            PetList petList = new PetList(){pets=Pets.value};
            return petList;
        }

        public async Task<PetList> requestWalkingPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>("adoptiionPet","GetAll",new Pet(){type="test",breed="ing",name="none"});

            Comunication<IList<Pet>> Pets = await tier2.requestServerAsync<Comunication<Pet>,Comunication<IList<Pet>>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(Pets));
            PetList petList = new PetList(){pets=Pets.value};
            return petList;
        }*/

        public async Task<Pet> requestPet(int id){
            Comunication<Pet> communicationClass = new Comunication<Pet>(theType,"Get",new Pet(){type="test",breed="ing",id=id});

            Comunication<Pet> PetList = await tier2.requestServerAsync<Comunication<Pet>,Comunication<Pet>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(PetList));
            return PetList.value;
        }

        public async Task<Pet> createPet(Pet newPet){
            Comunication<Pet> commClass = new Comunication<Pet>(theType,"Add",newPet);

            Comunication<Pet> thePet = await tier2.requestServerAsync<Comunication<Pet>,Comunication<Pet>>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(thePet));
            return thePet.value;
        }

        public async Task<Pet> deletePet(Pet petToDelete){//TODO delete 
            Comunication<Pet> commClass = new Comunication<Pet>(theType,"Remove",petToDelete);

            Comunication<string> serverResponse = await tier2.requestServerAsync<Comunication<Pet>,Comunication<string>>(commClass);

            return petToDelete;
        }

        public async Task<Pet> updatePet(Pet petToUpdate){ //may by changed in connection for better handling in Tier3
            Comunication<Pet> commClass = new Comunication<Pet>(theType,"Update",petToUpdate);

            Comunication<Pet> thePet = await tier2.requestServerAsync<Comunication<Pet>,Comunication<Pet>>(commClass);

            return thePet.value;
        }
    }
}