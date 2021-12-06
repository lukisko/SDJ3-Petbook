using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using business_logic.Model.Mediator;

using System.Text.Json;
using System.Text.Json.Serialization;
using business_logic.Model.PetPack;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController :ControllerBase
    {
        private IModel model;
        public MessageController(IModel model){
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Message>>> GetMessages([FromQuery] string token){
            Console.WriteLine("conneted to get messages!");
            await model.sendCode("pleva@usa.com");
            string token2 = await model.login("pleva@usa.com","FCVVPPA");
            Pet pet = new Pet(){
                name = "REX",
                type = "dog",
                description = "good dog",
                Birthdate = new DateTime(2020,10,10),
                statuses = new List<Status>(),
                user = new User(){
                    name = "Lukisko",
                    email = "pleva@usa.com"
                },
                city = new City(){
                    name = "theCity",
                    country = new Country(){
                        name = "USA"
                    }
                }
            };
            await model.createPetAsync(pet,token2);
            return StatusCode(501,"not implemented geting of messages with a person");
        }

        [HttpPost]
        public async Task<ActionResult<string>> SendMessage([FromQuery] string token, Message message){
            Console.WriteLine("conneted to get messages!");
            return StatusCode(501,"not implemented, sorry");
        }
    }
}