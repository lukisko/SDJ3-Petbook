using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business_logic.Model;

namespace business_logic.Controllers
{
    public interface IPetController
    {
        [HttpGet]
        Task<ActionResult<String>> GetPets();
        [HttpPost]
        Task<ActionResult<String>> AddPet(Pet pet,[FromQuery] string token);
    }
}