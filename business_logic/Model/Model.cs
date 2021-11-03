using System.Threading.Tasks;
using business_logic.Model.Mediator;
using System;

namespace business_logic.Model
{
    public class Model : IModel
    {
        private ITier2Mediator tier2Mediator;
        private IEmailHandler emailHandler;

        public Model(){
            tier2Mediator = new Tier2();
            emailHandler = new EmailHandler();
        }
        public bool Login(string email){
            try {
                emailHandler.sendEmail(email,"Your login link - PetBook","Testing Hello there!");
            } catch (Exception exception){
                Console.WriteLine("error occured!"+exception);
                return false;
            }
            return true;
        }
        public async Task<PetList> getPetsAsync(){
            
            PetList list = await tier2Mediator.requestPets();
            return list;
        }

        public async Task<Pet> createPetAsync(Pet pet){
            Pet newPet = await tier2Mediator.createPet(pet);
            return newPet;
        }
        //TODO make REST connect to model and model to socket
    }
}