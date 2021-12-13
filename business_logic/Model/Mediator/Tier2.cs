using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using business_logic.Model.UserPack;
using Entities;

namespace business_logic.Model.Mediator
{
    public class Tier2 : ITier2Mediator
    {
        private static readonly string HOST = "localhost";//"192.168.44.20";//"192.168.43.113";//"62.107.181.237";//"127.0.0.1";//
        private static readonly int PORT = 5123;//4758;//
        private TcpClient client;
        private NetworkStream stream;
        private Tier2Pets pets;
        private Tier2User users;
        private Tier2City cities;
        private Tier2Country countries;
        private Tier2Status statuses;
        public Tier2() : this(HOST,PORT) {
            
        }

        public Tier2(string host, int port){
            client = new TcpClient(host,port);

            stream = client.GetStream();

            pets = new Tier2Pets(this);
            this.users = new Tier2User(this);
            cities = new Tier2City(this);
            countries = new Tier2Country(this);
            statuses = new Tier2Status(this);

        }

        public async Task<PetList> requestPets(){
            PetList petList = await pets.requestPets();
            foreach (Pet pet in petList.pets){
                pet.statuses = await statuses.getStatusesOf(pet);
            }
            return petList;
        }

        public async Task<Pet> requestPet(int id){
            Pet pet = await pets.requestPet(id);
            if (pet == null){
                return null;
            }
            pet.statuses = await statuses.getStatusesOf(pet);
            return pet;
        }

        public async Task<IList<Pet>> requestPets(AuthorisedUser user){
            IList<Pet> petList = await pets.GetByUserEmail(user);
            Console.WriteLine(petList);
            if (petList == null){
                return new List<Pet>();
            }
            foreach (Pet pet in petList){
                pet.statuses = await statuses.getStatusesOf(pet);
            }
            return petList;
        }

        public async Task<Pet> createPet(Pet newPet){
            return await pets.createPet(newPet);
        }

        public async Task<Pet> updatePet(Pet newPet){
            return await pets.updatePet(newPet);
        }
        public async Task<Pet> deletePet(Pet oldPet){
            return await pets.deletePet(oldPet);
        }

        public async Task<IList<Pet>> requestPetsByStatus(string status){
            IList<Status> rightStatuses = await statuses.requestStatusByName(status);
            List<Pet> returnPets = new List<Pet>();
            foreach (Status tmpStatus in rightStatuses){
                Pet tmpPet = tmpStatus.pet;
                tmpPet.statuses = new List<Status>(){tmpStatus.copy()};
                returnPets.Add(tmpStatus.pet);
            }
            
            return returnPets;
        }

        public async Task<Status> getStatus(Status status){
            return await statuses.getStatus(status);
        }
        public async Task<Status> addStatus(Status newStatus){
            return await statuses.addStatus(newStatus);
        }
        public async Task<Status> updateStatus(Status newerStatus){
            return await statuses.updateStatus(newerStatus);
        }
        public async Task<Status> removeStatus(Status oldStatus){
            return await statuses.removeStatus(oldStatus);
        }

        public async Task<AuthorisedUser> GetUser(AuthorisedUser user){
            Console.WriteLine(this.users);
            AuthorisedUser authUser = await this.users.GetUser(user);
            //authUser.pets = 
            return authUser;
        }
        public async Task<AuthorisedUser> MakeUser(AuthorisedUser user){
            return await users.MakeUser(user);
        }

        public async Task<City> GetCity(City city){
            return await cities.getCity(city);
        }

        public async Task<City> AddCity(City city){
            return await cities.addCity(city);
        }

        public async Task<Country> GetCountry(Country country){
            return await countries.getCountry(country);
        }

        public async Task<Country> AddCountry(Country country){
            return await countries.addCountry(country);
        }

        public async Task<V> requestServerAsync<T,V>(T classToSend){
            //sending
            string s = JsonSerializer.Serialize(classToSend);
            Console.WriteLine("*****\nsending: \t"+s + "\n");
            byte[] dataToServer = Encoding.ASCII.GetBytes(s);
            await stream.WriteAsync(dataToServer);
            

            //receiving
            byte[] dataFromServer = new byte[8000];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);
            Console.WriteLine("*****\nreceiving: \t"+response + "\n");

            Comunication<Object> comm = JsonSerializer.Deserialize<Comunication<Object>>(response);
            if (String.IsNullOrEmpty(comm.type) || comm.type.Equals("error")){
                Console.WriteLine("Error from T3:\n"+response);
                throw new SystemException("internal system error");
            }

            V theResponseObj = JsonSerializer.Deserialize<V>(response);
            return theResponseObj;
        }
    }
}