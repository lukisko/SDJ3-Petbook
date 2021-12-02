using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business_logic.Model;
using System.Collections.Generic;

namespace business_logic.Controllers
{
    public interface IPetController
    {
        [HttpGet]
        Task<ActionResult<IList<Pet>>> GetPets([FromQuery] int? id, [FromQuery] string email, [FromQuery] string status);
        [HttpPost]
        Task<ActionResult<String>> AddPet(Pet pet,[FromQuery] string token);
    }
}