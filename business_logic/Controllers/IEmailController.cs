using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business_logic.Model;

namespace business_logic.Controllers
{
    public interface IEmailController
    {
        [HttpGet]
        Task<ActionResult<String>> SendEmail([FromQuery] string email);
    }
}