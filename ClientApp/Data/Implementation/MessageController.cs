using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Model;

namespace ClientApp.Data.Implementation
{
    public class MessageController : IMessageController
    {
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;
       // public Action<Object> RequestAnswerChange;
        private AccessToken _accessToken;

        public MessageController(AccessToken accessToken)
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
            this._accessToken = accessToken;
        }


        public async Task SendMessageAsync(Message message)
        {
            string serializedMessage = JsonSerializer.Serialize(message);
            HttpContent content = new StringContent(serializedMessage, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage =
                await client.PostAsync($"{StaticVariables.URL}/Message?token={""}", content);
            Console.WriteLine("I'm here");
            if (responseMessage.StatusCode == HttpStatusCode.NotImplemented)
            {
                throw new AuthenticationException(responseMessage.Content.ReadAsStringAsync().Result);
            }

            string reply = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(reply);
            // return reply;
        }

        public Task<IList<Message>> GetAllMessagesWithAUserAsync(int receiverPetId)
        {
            throw new NotImplementedException();
        }
    }
}