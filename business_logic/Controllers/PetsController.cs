using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;

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
        public ActionResult<String> GetPets(){
            //return "ok";
            Console.WriteLine("pets are: "+pets);
            string JsonString = JsonSerializer.Serialize(pets.GetPets());
            return JsonString;
        }

        [HttpPost]
        public ActionResult<String> AddPet(Pet pet){
            Pet newPet = pets.AddPet(pet);
            return StatusCode(200,newPet);
        }
    }
}