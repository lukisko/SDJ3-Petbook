using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        public async Task<string> requestPets(){
            Comunication<Pet> communicationClass = new Comunication<Pet>("pet","Get",null);

            byte[] dataToServer = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(communicationClass));
            await stream.WriteAsync(dataToServer);

            byte[] dataFromServer = new byte[1024];
            int byteReads = await stream.ReadAsync(dataFromServer,0,dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, byteReads);
            return response;
        }
    }
}