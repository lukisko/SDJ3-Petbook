using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using System.Net.Http;
using business_logic.Model.UserPack;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IModel model;

        public  UserController(IModel model){
            this.model = model;
            
        }

        [HttpGet]
        
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
                return StatusCode(200,token);
            }catch (Exception e){
                return StatusCode(400,"the login was not successful");
            }
        }

        [HttpPost]
        public async Task<ActionResult<AuthorisedUser>> Register(User newUser){
            Console.WriteLine("heeere2");
            //return StatusCode(500, "not running tier 3");
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