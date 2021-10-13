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
        [HttpGet]
        //[Route("{email:int}")]
        public ActionResult<String> Login([FromQuery] string email){
            Console.WriteLine(email);
            IEmailHandler emailHandler = new EmailHandler();
            try {
                emailHandler.sendEmail(email,"Your login link - PetBook","Testing Hello there!");
            } catch (Exception exception){
                Console.WriteLine("error occured!"+exception);
                return email;
            }
            return "OK";
            
        }
    }
}