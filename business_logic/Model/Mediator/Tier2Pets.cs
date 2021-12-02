using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        public async Task<Pet> requestPet(int id){
            Comunication<Pet> communicationClass = new Comunication<Pet>(theType,"Get",new Pet(){type="test",breed="ing",id=id});

            Comunication<Pet> PetList = await tier2.requestServerAsync<Comunication<Pet>,Comunication<Pet>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(PetList));
            return PetList.value;
        }

        public async Task<Pet> createPet(Pet newPet){
            Comunication<Pet> commClass = new Comunication<Pet>(theType,"Add",newPet);

            Pet thePet = await tier2.requestServerAsync<Comunication<Pet>,Pet>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(thePet));
            return thePet;
        }

        public async Task<Pet> deletePet(Pet petToDelete){
            Comunication<Pet> commClass = new Comunication<Pet>(theType,"Remove",petToDelete);

            Comunication<string> serverResponse = await tier2.requestServerAsync<Comunication<Pet>,Comunication<string>>(commClass);

            return petToDelete;
        }

        public async Task<Pet> updatePet(Pet petToUpdate){ //may by changed in connection for better handling in Tier3
            Comunication<Pet> commClass = new Comunication<Pet>(theType,"Update",petToUpdate);

            Pet thePet = await tier2.requestServerAsync<Comunication<Pet>,Pet>(commClass);

            return thePet;
        }
    }
}