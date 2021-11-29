using System;
using business_logic.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace ClientApp.Data
{
    public class PetController : IPetController
    {
        private string uri = "1https://localhost:5001";
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;

        public PetController()
        {
           
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);  
        }

        public async Task addPetAsync(Pet pet)
        {
            string serializedPet = JsonSerializer.Serialize(pet);
            HttpContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            await client.PostAsync($"{uri}/Pets", content);
        }

        public async Task<IList<Pet>> GetAllPetsAsync()
        {
            List<Pet> pets = new List<Pet>();
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/Pets");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Not good");
            }
            
            String reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonSerializer.Deserialize<List<Pet>>(reply);
            return pets;
        }
    }
}