using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Model;
using ClientApp.Pages;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Data.Implementation
{
    public class RequestController : IRequestController
    {
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;


        public RequestController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
        }

        public async Task<IList<User>> GetAllReceivedRequestsAsync(int petId)
        {
            IList<User> pets = new List<User>();
            HttpResponseMessage responseMessage = await client.GetAsync(
                $"{StaticVariables.URL}/Request?petId={petId}&token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}");

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }

            String reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonSerializer.Deserialize<List<User>>(reply);
            return pets;
        }
        public async Task<IList<Request>> GetAllRequestsAsync(string email, int petId)
        {
            IList<Request> requests = new List<Request>();
            HttpResponseMessage responseMessage = await client.GetAsync(
                $"{StaticVariables.URL}/Request?userId={email}&petId={petId}&token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}");

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }
            String reply = await responseMessage.Content.ReadAsStringAsync();
            requests= JsonSerializer.Deserialize<List<Request>>(reply);
            return requests;
        }

        public async Task SendRequestAsync(Request request)
        {
            string serializedRequest = JsonSerializer.Serialize(request);
            HttpContent content = new StringContent(serializedRequest, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage =
                await client.PostAsync(
                    $"{StaticVariables.URL}/Request?token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}",
                    content);
            Console.WriteLine("request token"+StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]);

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}