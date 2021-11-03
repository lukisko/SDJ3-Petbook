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

            var testing = JsonSerializer.Serialize(communicationClass);
            byte[] dataToServer = Encoding.ASCII.GetBytes(testing);
            Console.WriteLine("hello");
            await stream.WriteAsync(dataToServer);
            Console.WriteLine(dataToServer.Length);
            Console.WriteLine("2");
            byte[] dataFromServer = new byte[2048];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);
            Console.WriteLine("3");

            Comunication<PetList> PetList = JsonSerializer.Deserialize<Comunication<PetList>>(response);
            Console.WriteLine(JsonSerializer.Serialize(PetList));
            Console.WriteLine("out of mediator");
            return PetList.value;
        }

        public async Task<Pet> createPet(Pet newPet){
            Comunication<Pet> commClass = new Comunication<Pet>("pet","Add",newPet);

            byte[] dataToServer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(commClass));
            await stream.WriteAsync(dataToServer);

            byte[] dataFromServer = new byte[2048];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);

            Pet thePet = JsonSerializer.Deserialize<Pet>(response);
            Console.WriteLine(JsonSerializer.Serialize(thePet));
            return new Pet();
        }
    }
}