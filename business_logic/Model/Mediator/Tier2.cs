using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using business_logic.Model.UserPack;

namespace business_logic.Model.Mediator
{
    public class Tier2 : ITier2Mediator
    {
        private static readonly string HOST = "192.168.43.113";//"192.168.43.113";//"62.107.181.237";//"127.0.0.1";//
        private static readonly int PORT = 5123;//4758;//
        private TcpClient client;
        private NetworkStream stream;
        private Tier2Pets pets;
        private Tier2User users;
        public Tier2() {
            client = new TcpClient(HOST,PORT);
            stream = client.GetStream();
            pets = new Tier2Pets(this);
            this.users = new Tier2User(this);
        }

        public Tier2(string host, int port){
            client = new TcpClient(host,port);

            stream = client.GetStream();

            pets = new Tier2Pets(this);
            this.users = new Tier2User(this);
        }

        public async Task<PetList> requestPets(){
            return await pets.requestPets();
        }

        public async Task<Pet> createPet(Pet newPet){
            return await pets.createPet(newPet);
        }

        public async Task<AuthorisedUser> GetUser(AuthorisedUser user){
            Console.WriteLine("in tier2");
            Console.WriteLine(this.users);
            return await this.users.GetUser(user);
        }
        public async Task<AuthorisedUser> MakeUser(AuthorisedUser user){
            return await users.MakeUser(user);
        }

        public async Task<V> requestServerAsync<T,V>(T classToSend){
            //sending
            string s = JsonSerializer.Serialize(classToSend);
            Console.WriteLine("sending: \t"+s);
            byte[] dataToServer = Encoding.ASCII.GetBytes(s);
            await stream.WriteAsync(dataToServer);
            

            //receiving
            byte[] dataFromServer = new byte[2048];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);
            Console.WriteLine("receiving: \t"+response);

            V theResponseObj = JsonSerializer.Deserialize<V>(response);
            return theResponseObj;
        }
    }
}