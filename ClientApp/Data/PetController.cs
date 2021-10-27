using System

namespace ClientApp.Data
{
    public class PetController : IPetController
    {
        private string uri = "To be added";
        private readonly HttpClient client;
        private HttpClientHandler clientHandler;

        public PetController()
        {
            clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            client = new HttpClient(clientHandler);
        }

        public async Task AddPetAsync(Pet pet)
        {
            string serializedPet = JsonConvert.SerializeObject(pet);
            StringContent content = new StringContent(serializedPet, Encoding.UTF8, "application/json");
            await client.PostAsync($"{uri}/Pets", content);
        }

        public async Task<IList<Pet>> GetAllPetsAsync(Pet pet)
        {
            List<Pet> pets = new List<Pet>();
            HttpResponseMessage responseMessage = await client.GetAsync($"{uri}/Pets");
            String reply = await responseMessage.Content.ReadAsStringAsync();
            pets = JsonConvert.DeserializeObject<List<Pet>>(reply);
            return pets;
        }
    }
}