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

            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                string token =
                    responseMessage.Content.ReadAsStringAsync().Result;
                _context.Session.SetString(StaticVariables.AccessToken, token);
                var tok = _context.Session.GetString(StaticVariables.AccessToken);
                Console.WriteLine(tok);
            }

            //if check for the token 
            // store it 
            HttpResponseMessage responseMessage2 =
                await client.GetAsync($"{StaticVariables.URL}/User?email={email}&code={code}");
            Console.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
            string reply = await responseMessage.Content.ReadAsStringAsync();

            User user = new User();


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
    }
}