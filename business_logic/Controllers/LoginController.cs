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
    public class UserController : ControllerBase
    {
        private IModel model;

        public UserController(IModel model)
        {
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<User>> Login([FromQuery] string email, [FromQuery] string code)
        {
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(code))
            {
                return StatusCode(400, "please provide email and code");
            }

            try
            {
                User usr = await model.login(email, code);
                return StatusCode(200, usr);
            }
            catch (Exception e)
            {
                return StatusCode(400, "the login was not successful");
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> Register(User newUser)
        {
            try
            {
                User usr = await model.register(newUser);
                return StatusCode(200, usr);
            }
            catch (Exception e)
            {
                return StatusCode(400, "registration not successfull");
            }
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private IModel model;

        public EmailController(IModel model)
        {
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<String>> SendEmail([FromQuery] string email)
        {
            if (await model.sendCode(email))
            {
                return StatusCode(200);
            }

            return StatusCode(400, "the email od not exist or is not in our system.");
        }
    }
}