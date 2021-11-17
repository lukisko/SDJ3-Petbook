using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace business_logic.Model.Mediator
{
    public class Tier2 : ITier2Mediator
    {
        private static readonly string HOST = "127.0.0.1";//"62.107.181.237";//"127.0.0.1";//
        private static readonly int PORT = 5123;//4758;//
        private TcpClient client;
        private NetworkStream stream;
        public Tier2() {
            client = new TcpClient(HOST,PORT);

            stream = client.GetStream();
        }

        public Tier2(string host, int port){
            client = new TcpClient(host,port);

            stream = client.GetStream();
        }

        public async Task<PetList> requestPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>("pet","Get",new Pet(){type="test",breed="ing",name="none"});

            Comunication<PetList> PetList = await this.requestServerAsync<Comunication<Pet>,Comunication<PetList>>(communicationClass);

            Console.WriteLine(JsonSerializer.Serialize(PetList));
            return PetList.value;
        }

        public async Task<Pet> createPet(Pet newPet){
            Comunication<Pet> commClass = new Comunication<Pet>("pet","Add",newPet);

            Pet thePet = await this.requestServerAsync<Comunication<Pet>,Pet>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(thePet));
            return thePet;
        }

        public async Task<User> GetUser(User user){
            Comunication<User> commClass = new Comunication<User>("user","Get",user);

            Comunication<User> theUser = await this.requestServerAsync<Comunication<User>,Comunication<User>>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(theUser));
            return theUser.value;//TODO should I get pet or comunication pet???
        }
        public async Task<User> MakeUser(User user){
            Comunication<User> commClass = new Comunication<User>("user","Add",user);

            User theUser = await this.requestServerAsync<Comunication<User>,User>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(theUser));
            return theUser;
        }

        private async Task<V> requestServerAsync<T,V>(T classToSend){
            //sending
            byte[] dataToServer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(classToSend));
            await stream.WriteAsync(dataToServer);

            //receiving
            byte[] dataFromServer = new byte[2048];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);

            V theResponseObj = JsonSerializer.Deserialize<V>(response);
            return theResponseObj;
        }
    }
}