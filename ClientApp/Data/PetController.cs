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
        private static readonly HttpClientHandler handler = new HttpClientHandler(){
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };
        private static readonly HttpClient client = new HttpClient(handler);
        private string uri = "https://localhost:5001";//"https://84.238.40.156:5001";
        private HttpClientHandler clientHandler;

        public PetController()
        {
            //clientHandler = new HttpClientHandler();
            //clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            //client = new HttpClient(clientHandler);
        }

        public async Task addPetAsync(Pet pet)
        {
            string serializedPet = JsonSerializer.Serialize(pet);
            StringContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            await client.PostAsync($"{uri}/Pets", content);
        }

        public async Task<IList<Pet>> GetAllPetsAsync()
        {
            List<Pet> pets = new List<Pet>();
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/Pets");
            String reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonSerializer.Deserialize<List<Pet>>(reply);
            return pets;
        }
    }
}