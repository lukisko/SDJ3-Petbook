using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business_logic.Model;

namespace business_logic.Controllers
{
    public interface IUserControl
    {
         [HttpGet]
        Task<ActionResult<String>> Login([FromQuery] string email, [FromQuery] string code);
        [HttpPost]
        Task<ActionResult<User>> Register(User newUser);
    }
}