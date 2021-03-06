using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using Entities;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserControl model;

        public  UserController(IUserControl model){
            this.model = model;
            
        }

        [HttpGet]
        /// <summary>
        /// final login for user using email and code.
        /// </summary>
        /// <param name="email">user's email address</param>
        /// <param name="code">code that was send to the email address</param>
        /// <returns>access token needed in other operations</returns>
        /// <remarks>
        /// testing
        /// </remarks>
        public async Task<ActionResult<String>> Login([FromQuery] string email, [FromQuery] string code){
            Console.WriteLine("heeere");
            //return StatusCode(500,"not running tier3");
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(code)){
                return StatusCode(400,"please provide email and code");
            }
            try {
                string token = await model.login(email,code);
                if (String.IsNullOrEmpty(token)){
                    return StatusCode(404,"the login was not succesfull");
                }
                Console.WriteLine("send the token");
                return StatusCode(200,token);
            }catch {
                return StatusCode(400,"the login was not successful");
            }
        }

        [HttpPost]
        public async Task<ActionResult<AuthorisedUser>> Register(User newUser){
            Console.WriteLine("heeere2");
            //User usr = await model.register(newUser);
            try {
                Console.WriteLine(newUser.name);
                User usr = await model.register(newUser);
                return StatusCode(200,"final");//usr); //new User());
            }catch (Exception e){
                Console.WriteLine(e);
                return StatusCode(400,"registration not successfull");
            }
            
        }
    }

    
}