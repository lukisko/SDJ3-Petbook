using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using ClientApp.Model;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


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

        public async Task<Pet> AddPetAsync(Pet pet)
        {
            string serializedPet = JsonSerializer.Serialize(pet);
            HttpContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage =
                await client.PostAsync(
                    $"{StaticVariables.URL}/Pets?token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}",
                    content);

            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }

            string reply = await responseMessage.Content.ReadAsStringAsync();
            Pet updatedPet = JsonConvert.DeserializeObject<Pet>(reply);
            return updatedPet;
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

        public async Task<IList<Pet>> GetAllUserPetsAsync()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(
                $"{StaticVariables.URL}/Pets?token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}");

            if (responseMessage.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }
            IList<Pet> pets = new List<Pet>();
            string reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonSerializer.Deserialize<IList<Pet>>(reply);
            return pets;
        }

        public async Task<Pet> GetPetProfileAsync(int petId)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(
                $"{StaticVariables.URL}/Pets?petId={petId}&token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}");

            // if (responseMessage.StatusCode == HttpStatusCode.InternalServerError)
            // {
            //     throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            // }

            string reply = await responseMessage.Content.ReadAsStringAsync();
            Pet pet = JsonSerializer.Deserialize<Pet>(reply);
            return pet;
        }

        public async Task<Pet> UpdatePetAsync(Pet pet)
        {
            string serializedPet = JsonSerializer.Serialize(pet);
            HttpContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage =
                await client.PutAsync(
                    $"{StaticVariables.URL}/Pets?token={StaticVariables.AccessTokensLibrary[StaticVariables.AccessToken]}",
                    content);
            if (responseMessage.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }

            if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }

            if (responseMessage.StatusCode == HttpStatusCode.Created)
            {
                // Well I guess I did it 
                // But i Forgot what it means
                RequestAnswerChange.Invoke(responseMessage.Content);
            }

            string reply = await responseMessage.Content.ReadAsStringAsync();
            Pet updatedPet = JsonConvert.DeserializeObject<Pet>(reply);
            return updatedPet;
        }

        public async Task DeletePet(int petId)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{StaticVariables.URL}/Pets?petId={petId}");
            if (responseMessage.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}