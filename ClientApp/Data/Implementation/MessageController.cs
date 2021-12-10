using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ClientApp.Data.Implementation
{
    public class MessageController : IMessageController
    {
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;


        public MessageController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
        }


        public async Task SendMessageAsync(Message message)
        {
            string serializedMessage = JsonSerializer.Serialize(message);
            HttpContent content = new StringContent(serializedMessage, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage =
                await client.PostAsync(
                    $"{StaticVariables.URL}/Message?token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}",
                    content);

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            string reply = await responseMessage.Content.ReadAsStringAsync();
        }


        public async Task<IList<Message>> GetAllMessagesAsync(int receiverId, int senderId)
        {
            Console.WriteLine("Controller receiver"+receiverId+"sender id"+senderId);
            HttpResponseMessage responseMessage = await client.GetAsync(
                $"{StaticVariables.URL}/Message?receiverPetId={receiverId}&senderPetId={senderId}&token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}");

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            IList<Message> messages = new List<Message>();
            string reply = await responseMessage.Content.ReadAsStringAsync();
            messages = JsonConvert.DeserializeObject<IList<Message>>(reply);
            return messages;
        }

        public async Task<IList<Pet>> GetAllMessagePets(int loggedInPet)
        {
            Console.WriteLine($"Loggedinpet{loggedInPet}");
            HttpResponseMessage responseMessage = await client.GetAsync(
                $"{StaticVariables.URL}/Message?receiverPetId={loggedInPet}&token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}");

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            IList<Pet> pets = new List<Pet>();
            string reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonConvert.DeserializeObject<IList<Pet>>(reply);
            
            return pets;
        }
    }
}