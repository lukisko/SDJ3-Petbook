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
    public class Tier2 : ITier2Singleton
    {
        private static readonly string HOST = "localhost";//"192.168.44.20";//"192.168.43.113";//"62.107.181.237";//"127.0.0.1";//
        private static readonly int PORT = 5123;//4758;//
        private TcpClient client;
        private NetworkStream stream;
        public Tier2() {
            client = new TcpClient(HOST,PORT);

            stream = client.GetStream();

            //pets = new Tier2Pets(this);
            //this.users = new Tier2User(this);
            //cities = new Tier2City(this);
            //countries = new Tier2Country(this);
            //statuses = new Tier2Status(this);
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