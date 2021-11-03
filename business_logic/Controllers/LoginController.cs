using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private IModel model;

        public  LoginController(IModel model){
            this.model = model;
        }

        [HttpGet]
        //[Route("{email:int}")]
        public ActionResult<String> Login([FromQuery] string email){
            Console.WriteLine(email);
            //var testing = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine((testing!=null)?testing:"nothing");
            return (model.Login(email))? "ok" : email;
        }
    }
}