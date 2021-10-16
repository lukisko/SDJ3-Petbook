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
        private static readonly string HOST = "localhost";
        private static readonly int PORT = 4569;
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

        public async Task<List<Pet>> requestPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>("pet","Get",null);

            byte[] dataToServer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(communicationClass));
            await stream.WriteAsync(dataToServer);

            byte[] dataFromServer = new byte[2048];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);

            List<Pet> PetList = JsonSerializer.Deserialize<List<Pet>>(response);
            Console.WriteLine(PetList);
            return PetList;
        }

        public async Task<Pet> createPet(Pet newPet){
            Comunication<Pet> commClass = new Comunication<Pet>("pet","Add",newPet);

            byte[] dataToServer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(commClass));
            await stream.WriteAsync(dataToServer);

            byte[] dataFromServer = new byte[2048];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);

            Pet thePet = JsonSerializer.Deserialize<Pet>(response);
            Console.WriteLine(thePet);
            return new Pet();
        }
    }
}