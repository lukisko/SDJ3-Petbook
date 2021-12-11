using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business_logic.Model;
using System.Collections.Generic;

namespace business_logic.Controllers
{
    public interface IPetControl
    {
        [HttpGet]
        Task<ActionResult<IList<Pet>>> GetPets([FromQuery] int? id, [FromQuery] string email, 
            [FromQuery] string status,[FromQuery] string type,[FromQuery] string breed,[FromQuery] char gender,
            [FromQuery] DateTime birthday, [FromQuery] string name);
        [HttpPost]
        Task<ActionResult<Pet>> AddPet(Pet pet,[FromQuery] string token);
        [HttpPut]
        Task<ActionResult<Pet>> UpdatePet(Pet pet, [FromQuery] string token);
    }
}