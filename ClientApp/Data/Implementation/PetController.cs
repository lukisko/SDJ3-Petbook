using System;

using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using ClientApp.Model;


namespace ClientApp.Data.Implementation
{
    public class PetController : IPetController
    {
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;
        public Action<Object> RequestAnswerChange; 
        public PetController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
        }

        public async Task AddPetAsync(Pet pet)
        {
            string serializedPet = JsonSerializer.Serialize(pet);
            HttpContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage= await client.PostAsync($"{StaticVariables.URL}/Pets?token={"somestring"}", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                RequestAnswerChange.Invoke(responseMessage.Content);
            }
            else
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }

        public async Task<IList<Pet>> GetAllPetsAsync()
        {
            List<Pet> pets = new List<Pet>();
            HttpResponseMessage responseMessage = await client.GetAsync($"{StaticVariables.URL}/Pets");
            
            if (responseMessage.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }
            String reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonSerializer.Deserialize<List<Pet>>(reply);
            return pets;
        }

        public Task<IList<Pet>> GetAllUserPetsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePetAsync(Pet pet)
        {
            string serializedPet = JsonSerializer.Serialize(pet);
            HttpContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage= await client.PostAsync($"{StaticVariables.URL}/Pets?token={"somestring"}", content);
            if (responseMessage.StatusCode == HttpStatusCode.OK)
            {
                RequestAnswerChange.Invoke(responseMessage.Content);
            }
            else
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}