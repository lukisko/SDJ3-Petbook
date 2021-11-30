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
    public class PetsController : ControllerBase, IPetController
    {
        private IModel model;
        public PetsController(IModel model){
            this.model = model;
        }
        [HttpGet]
        public async Task<ActionResult<String>> GetPets(){
            PetList listToReturn = await model.getPetsAsync();
            return JsonSerializer.Serialize(listToReturn.pets);
        }

        [HttpPost]
        public async Task<ActionResult<String>> AddPet(Pet pet, [FromQuery] string token){

            Pet newPet = await model.createPetAsync(pet,token);
            return StatusCode(200,newPet);
        }
    }
}