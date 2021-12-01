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
        
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;
        private AccessToken _accessToken;

        public UserController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
            this._accessToken = new AccessToken();
        }

        public async Task<string> Register(User newUser)
        {
            string serializedUser = JsonSerializer.Serialize(newUser);
            HttpContent content = new StringContent(serializedUser, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{StaticVariables.URL}/User", content);
            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            string reply = await responseMessage.Content.ReadAsStringAsync();
            return reply;
        }

        public async Task<User> Login(string email, string code)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{StaticVariables.URL}/User?email={email}&code={code}");

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
            string token = await responseMessage.Content.ReadAsStringAsync();
            HttpResponseMessage responseMessage2 = await client.GetAsync($"{StaticVariables.URL}/AuthorisedUser?token={token}");
            
            if (responseMessage2.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage2.Content.ReadAsStringAsync().Result);
            }
            string userAsJson = await responseMessage2.Content.ReadAsStringAsync();
            User reply = JsonSerializer.Deserialize<User>(userAsJson);
            _accessToken.Token = token;
            return reply;
        }

        public async Task SendEmail(string email)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{StaticVariables.URL}/Email?email={email}");

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}