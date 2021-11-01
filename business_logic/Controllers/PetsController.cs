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

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        private IPetsData pets;
        public PetsController(IPetsData data){
            pets = data;
        }
        [HttpGet]
        public async Task<ActionResult<String>> GetPets(){
            //return "ok";
            /*Console.WriteLine("pets are: "+pets);
            string JsonString = JsonSerializer.Serialize(pets.GetPets());
            return JsonString;*/
            Console.WriteLine("I am inside");
            ITier2Mediator med = new Tier2();
            Console.WriteLine("Tier2 connected!");
            PetList list = await med.requestPets();
            return JsonSerializer.Serialize(list.pets);
        }

        [HttpPost]
        public async Task<ActionResult<String>> AddPet(Pet pet){
            //Pet newPet = pets.AddPet(pet);
            ITier2Mediator med = new Tier2();
            Pet newPet = await med.createPet(pet);
            Console.WriteLine("adding new pet");
            return StatusCode(200,newPet);
        }
    }
}