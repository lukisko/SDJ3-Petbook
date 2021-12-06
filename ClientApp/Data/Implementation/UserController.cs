using System;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Model;


namespace ClientApp.Data.Implementation
{
    public class UserController : IUserController
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;

        public UserController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
        }

        public async Task<string> Register(User newUser)
        {   
            string serializedUser = JsonSerializer.Serialize(newUser);
            HttpContent content = new StringContent(serializedUser, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{uri}/User", content);
            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
            
            string reply = await responseMessage.Content.ReadAsStringAsync();
            return reply;
        }

        public async Task<User> Login(string email, string code)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/User?email={email}&code={code}");
            
            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
            string token = await responseMessage.Content.ReadAsStringAsync();
            HttpResponseMessage responseMessage2 = await client.GetAsync($"{uri}/AuthorisedUser?token={token}");
            
            if (responseMessage2.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage2.Content.ReadAsStringAsync().Result);
            }
            string userAsJson = await responseMessage2.Content.ReadAsStringAsync();
            User reply = JsonSerializer.Deserialize<User>(userAsJson);
            return reply;
        }

        public async Task SendEmail(string email)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/Email?email={email}");
            
            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}