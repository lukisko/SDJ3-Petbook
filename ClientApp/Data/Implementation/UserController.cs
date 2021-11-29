using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using business_logic.Model;

namespace ClientApp.Data
{
    public class UserController : IUserController
    {
        private string uri = "https://192.168.44.32:5001";
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;

        public UserController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
        }

        public async Task<User> Register(User newUser)
        {
            string serializedUser = JsonSerializer.Serialize(newUser);
            HttpContent content = new StringContent(serializedUser, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync($"{uri}/User", content);

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            string reply = await responseMessage.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(reply);
            return user;
        }

        public async Task<User> Login(string email, string code)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}?email={email}&code={code}");
            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
            string reply = await responseMessage.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(reply);
            return user;
        }

        public async Task SendEmail(string email)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/{email}");

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
          // would it make sense to return something?
        }
    }
}