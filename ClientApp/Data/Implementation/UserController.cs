using System;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace ClientApp.Data.Implementation
{
    public class UserController : IUserController
    {
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;

        private HttpContext _context;

        public UserController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
            _context = new DefaultHttpContext();
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
            HttpResponseMessage responseMessage =
                await client.GetAsync($"{StaticVariables.URL}/User?email={email}&code={code}");

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            if (responseMessage.StatusCode == HttpStatusCode.NotFound)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            StaticVariables.AccessToken = GenerateRandomKey();
            var token = responseMessage.Content.ReadAsStringAsync().Result;
            StaticVariables.AccessTokensLibrary.Add(StaticVariables.AccessToken, token);

            // test
            var tok = StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken];
            Console.WriteLine(tok);
            //test
            HttpResponseMessage authUserResponseMessage =
                await client.GetAsync(
                    $"{StaticVariables.URL}/AuthorisedUser?token={tok}");
            if (responseMessage.StatusCode == HttpStatusCode.NotFound)
            {
                throw new AuthenticationException(authUserResponseMessage.Content.ReadAsStringAsync().Result);
            }

            Console.WriteLine(authUserResponseMessage.Content.ReadAsStringAsync().Result);
            string reply = await authUserResponseMessage.Content.ReadAsStringAsync();
            User user = JsonConvert.DeserializeObject<User>(reply);
            return user;
        }

        public async Task SendEmail(string email)
        {
            HttpResponseMessage responseMessage = await client.GetAsync($"{StaticVariables.URL}/Email?email={email}");

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }

        private string GenerateRandomKey()
        {
            Random r = new Random();
            var x = r.Next(0, 1000000);
            string s = x.ToString("000000");
            return s;
        }
    }
}