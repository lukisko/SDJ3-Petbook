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
        private IModel model;
        public PetsController(IModel model){
            this.model = model;
        }
        [HttpGet]
        public async Task<ActionResult<IList<Pet>>> GetPets([FromQuery] int? id, [FromQuery] string email, 
            [FromQuery] string status,[FromQuery] string type,[FromQuery] string breed,[FromQuery] char gender,
            [FromQuery] DateTime birthday,[FromQuery] string name){
            try {
                return StatusCode(200,await model.getPetsAsync(id,email,status,type,breed,gender,birthday,name));
            } catch (Exception e){
                return StatusCode(500,e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Pet>> AddPet(Pet pet, [FromQuery] string token){
            if (String.IsNullOrEmpty(token)){
                return StatusCode(400, "token needs to be specified.");
            }
            try {
                Pet newPet = await model.createPetAsync(pet,token);
                return StatusCode(201,newPet);
            } catch (AccessViolationException e){
                return StatusCode(401, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Pet>> UpdatePet(Pet pet, [FromQuery] string token){
            if (String.IsNullOrEmpty(token)){
                return StatusCode(400, "token needs to be specified.");
            }
            try {
                Pet newerPet = await model.updatePetAsync(pet,token);
                return StatusCode(201, newerPet);
            } catch (AccessViolationException e){
                return StatusCode(401,e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<Pet>> DeletePet([FromQuery] int petId, [FromQuery] string token){
            if (string.IsNullOrEmpty(token)){
                return StatusCode(400, "token needs to be specified.");
            }
            try {
                Pet oldPet = await model.deletePetAsync(new Pet(){id = petId},token);
                return StatusCode(200, oldPet);
            } catch (AccessViolationException e){
                return StatusCode(401, e.Message);
            }
        }
    }
}