using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using business_logic.Model.Login;
using Entities;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private IUserControl userControl;
        private IMessageControl messageControl;
        private IPetControl petControl;
        private ILoginManager loginManager;

        public TestController(IUserControl userControl,
        IMessageControl messageControl,IPetControl petControl, ILoginManager loginManager)
        {
            this.userControl = userControl;
            this.messageControl = messageControl;
            this.petControl = petControl;
            this.loginManager = loginManager;
        }

        [HttpGet]
        public async Task<ActionResult<String>> TestEverything([FromQuery] string newEmailAddress)
        {
            string response = "";
            int number = 1;
            Pet thePet = new Pet();
            Console.WriteLine($"Test {number} started:");
            string emailAddress = newEmailAddress;
            string token = "";
            try{
                await userControl.register(new Entities.User(){name = "test", email = emailAddress});
                //await model.sendCode(emailAddress);
                response+= "test 1 succeded\n";
            } catch {
                Console.WriteLine("Test 1 failed or you did not change email address!");
                response+= "test 1 (register) not succeded\n";
            }

            Console.WriteLine("\ntest 2 started:");
            try{
                token = await userControl.login(emailAddress,"FCVVPPA");
                Console.WriteLine("Test 2 successful");
                response+= "test 2 succeded\n";
            } catch {
                Console.WriteLine("Test 2 failed!");
                response+= "test 2 (login) not succeded\n";
            }

            Console.WriteLine("\ntest 3 started:");
            try{
                Pet pet = new Pet(){
                    name = "T-rex",
                    id = 0,
                    type = "dinosaur",
                    breed = "I do not know",
                    description = "He is scary",
                    birthdate = new DateTime(2021,1,1),
                    city = new City(){
                        name = "Billund",
                        country = new Country(){
                            name = "Denmark"
                        }
                    },
                    user = new Entities.User(){
                        name = "string",
                        email = "string"
                    },
                    gender = 'F',
                    statuses = new List<Status>()
                };
                thePet = await petControl.createPetAsync(pet, token);
                Console.WriteLine("Test 3 successful");
                response+= "test 3 succeded\n";
            } catch (Exception e) {
                Console.WriteLine("Test 3 failed!");
                Console.WriteLine(e);
                response+= "test 3 (add pet) not succeded \n";
            }
            //0/////////////////////////////////////
            Console.WriteLine("\ntest 4 started:");
            try{
                await petControl.getPetsAsync(null,null,null,null,null,null,null,null);
                Console.WriteLine("Test 4 successful");
                response+= "test 4 succeded\n";
            } catch {
                Console.WriteLine("Test 4 failed!");
                response+= "test 4 (get all pets) not succeded\n";
            }
            //0/////////////////////////////////////
            Console.WriteLine("\ntest 5 started:");
            try{
                await petControl.getPetsAsync(null,emailAddress,null,null,null,null,null,null);
                Console.WriteLine("Test 5 successful");
                response+= "test 5 succeded\n";
            } catch (Exception e){
                Console.WriteLine($"Test 5 failed!\n{e}");
                response+= "test 5 (get pets or a user) not succeded\n";
            }
            //0/////////////////////////////////////
            Console.WriteLine("\ntest 6 started:");
            try{
                Status status = new Status(){
                    name = "walking",
                    id = 0
                };
                thePet.statuses.Add(status);
                await petControl.updatePetAsync(thePet, token);
                Pet pet = (await petControl.getPetsAsync(thePet.id,null,null,null,null,null,null,null))[0];
                if (pet.statuses.Count == 0){
                    throw new Exception("status was not added");
                }
                Console.WriteLine("Test 6 successful, there are "+pet.statuses.Count+" statuses.");
                response+= "test 6 succeded\n";
            } catch (Exception e){
                Console.WriteLine(e);
                Console.WriteLine("Test 6 failed!");
                response+= "test 6 (add status) not succeded\n";
            }
            //0/////////////////////////////////////
            number = 7;
            Console.WriteLine($"\nTest {number} started:");
            try{
                Status status = new Status(){
                    name = "walking",
                    id = (await petControl.getPetsAsync(thePet.id,null,null,null,null,null,null,null))[0].statuses[0].id,
                    user = new User(){
                        name = "Lukas",
                        email = "pleva@usa.com"
                    }
                };
                thePet.statuses = new List<Status>(){status};
                await petControl.updatePetAsync(thePet,token);
                thePet = (await petControl.getPetsAsync(thePet.id,null,null,null,null,null,null,null))[0];
                if (thePet.statuses[0].user.email != "pleva@usa.com"){
                    throw new Exception("update do not work.");
                }
                Console.WriteLine($"Test {number} successful");
                response+= $"test {number} succeded\n";
            } catch (Exception e){
                Console.WriteLine($"Test {number} failed!\n{e}");
                response+= $"test {number} (update status) not succeded\n";
            }
            //0/////////////////////////////////////
            number = 8;
            Console.WriteLine($"\ntest {number} started:");
            try{
                string email = loginManager.getUserWithToken(token);
                AuthorisedUser user = await userControl.GetUser(email);
                user.pets = (await petControl.getPetsAsync(null,email,null,null,null,null,null,null)).ToArray();

                Console.WriteLine($"Test {number} successful");
                response+= $"test {number} succeded\n";
            } catch (Exception e){
                Console.WriteLine($"Test {number} failed!\n{e}");
                response+= $"test {number} (get all pets of) not succeded\n";
            }
            //0/////////////////////////////////////
            number = 9;
            Console.WriteLine($"\ntest {number} started:");
            try{
                Message msg = new Message(){
                    ReceiverPetId = 15,
                    SenderPetId = thePet.id,
                    MessageBody = "hello Pet.",
                    DateTime = new DateTime()
                };
                await messageControl.sendMessage(msg,token);
                Console.WriteLine($"Test {number} successful");
                response+= $"test {number} succeded\n";
            } catch (Exception e){
                Console.WriteLine($"Test {number} failed!\n{e}");
                response+= $"test {number} (send message) not succeded\n";
            }
            //0/////////////////////////////////////
            number = 10;
            Console.WriteLine($"\ntest {number} started:");
            try{
                thePet.statuses = new List<Status>();
                await petControl.updatePetAsync(thePet, token);
                Console.WriteLine($"Test {number} successful");
                response+= $"test {number} succeded\n";
            } catch {
                Console.WriteLine($"Test {number} failed!");
                response+= $"test {number} (remove status) not succeded\n";
            }
            //0/////////////////////////////////////
            number = 11;
            Console.WriteLine($"\nTest {number} started:");
            try{
                await petControl.deletePetAsync(thePet,token);
                Console.WriteLine($"Test {number} successful");
                response+= $"test {number} succeded\n";
            } catch {
                Console.WriteLine($"Test {number} failed!");
                response+= $"test {number} (remove pet) not succeded\n";
            }

            userControl.sendCode("pleva@usa.com");
            
            return StatusCode(301, response);
            
        }

        private string makeTest(Action testMethod, int number, string testType){
            Console.WriteLine($"\ntest "+number+" ({testType})started:");
            try {
                testMethod();
                Console.WriteLine("Test "+number+" succesfull.");
                return $"test {number} succeded\n";
            } catch {
                Console.WriteLine($"Test {number} failed!");
                return $"test {number} ({testType}) not succesfull";
            }
        }
    }
}