using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace business_logic.Model.Mediator
{
    public class Tier2Pets
    {
        private Tier2 tier2;
        public Tier2Pets(Tier2 tier2){
            this.tier2 = tier2;
        }

        public async Task<PetList> requestPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>("pet","GetAll",new Pet(){type="test",breed="ing",name="none"});

            Comunication<PetList> PetList = await tier2.requestServerAsync<Comunication<Pet>,Comunication<PetList>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(PetList));
            return PetList.value;
        }

        public async Task<Pet> requestPet(int id){
            Comunication<Pet> communicationClass = new Comunication<Pet>("pet","Get",new Pet(){type="test",breed="ing",id=id});

            Comunication<Pet> PetList = await tier2.requestServerAsync<Comunication<Pet>,Comunication<Pet>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(PetList));
            return PetList.value;
        }

        public async Task<Pet> createPet(Pet newPet){
            Comunication<Pet> commClass = new Comunication<Pet>("pet","Add",newPet);

            Pet thePet = await tier2.requestServerAsync<Comunication<Pet>,Pet>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(thePet));
            return thePet;
        }
    }
}