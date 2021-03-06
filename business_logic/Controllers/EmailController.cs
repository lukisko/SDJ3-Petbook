using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using System.Net.Http;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private IUserControl model;

        public EmailController(IUserControl model) //THis is very weird that it do not work with IEmailControl but it work with IModel
        {
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<String>> SendEmail([FromQuery] string email)
        {
            //return StatusCode(500,"sorry server down");
            if (await model.sendCode(email))
            {
                return StatusCode(200);
            }
            else
            {
                return StatusCode(400, "the email do not exist or is not in our system.");
            }
        }
    }
}