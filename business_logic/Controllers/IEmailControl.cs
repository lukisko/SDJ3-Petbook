using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using business_logic.Model;

namespace business_logic.Controllers
{
    public interface IEmailControl
    {
        Task<ActionResult<String>> SendEmail([FromQuery] string email);
    }
}