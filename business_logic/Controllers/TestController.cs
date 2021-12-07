using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using System.Net.Http;
using business_logic.Model.UserPack;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private IModel model;

        public TestController(IModel model)
        {
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<String>> TestEverything([FromQuery] string newEmailAddress)
        {
            string response = "";
            Pet thePet = new Pet();
            Console.WriteLine("Test 1 started:");
            string emailAddress = newEmailAddress;
            string token = "";
            try{
                await model.register(new Model.User(){name = "test", email = emailAddress});
                response+= "test 1 succeded\n";
            } catch {
                Console.WriteLine("Test 1 failed or you did not change email address!");
                response+= "test 1 (register) not succeded\n";
            }

            Console.WriteLine("\ntest 2 started:");
            try{
                token = await model.login(emailAddress,"FCVVPPA");
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
                    user = new Model.User(){
                        name = "string",
                        email = "string"
                    },
                    gender = 'F',
                    statuses = new List<Status>()
                };
                thePet = await model.createPetAsync(pet, token);
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
                await model.getPetsAsync();
                Console.WriteLine("Test 4 successful");
                response+= "test 4 succeded\n";
            } catch {
                Console.WriteLine("Test 4 failed!");
                response+= "test 4 (get all pets) not succeded\n";
            }
            //0/////////////////////////////////////
            Console.WriteLine("\ntest 5 started:");
            try{
                await model.getPetsAsync(new AuthorisedUser(){email =emailAddress});
                Console.WriteLine("Test 5 successful");
                response+= "test 5 succeded\n";
            } catch {
                Console.WriteLine("Test 5 failed!");
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
                Pet pet = await model.updatePetAsync(thePet, token);
                if (pet.statuses.Count == 0){
                    throw new Exception("status was not added");
                }
                Console.WriteLine("Test 6 successful");
                response+= "test 6 succeded\n";
            } catch {
                Console.WriteLine("Test 6 failed!");
                response+= "test 6 (add status) not succeded\n";
            }
            //0/////////////////////////////////////
            Console.WriteLine("\ntest 7 started:");
            try{
                thePet.statuses = new List<Status>();
                await model.updatePetAsync(thePet, token);
                Console.WriteLine("Test 7 successful");
                response+= "test 7 succeded\n";
            } catch {
                Console.WriteLine("Test 7 failed!");
                response+= "test 7 (remove status) not succeded\n";
            }
            //0/////////////////////////////////////
            Console.WriteLine("\nTest 8 started:");
            try{
                await model.deletePetAsync(thePet,token);
                Console.WriteLine("Test 8 successful");
                response+= "test 7 succeded\n";
            } catch {
                Console.WriteLine("Test 8 failed!");
                response+= "test 8 (remove pet) not succeded\n";
            }
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