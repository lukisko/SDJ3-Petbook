using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using System.Net.Http;

namespace business_logic.Controllers //TODO create interface for this and pet controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase, ILoginController
    {
        private IModel model;

        public  UserController(IModel model){
            this.model = model;
            
        }

        [HttpGet]
        public async Task<ActionResult<String>> Login([FromQuery] string email, [FromQuery] string code){
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(code)){
                return StatusCode(400,"please provide email and code");
            }
            try {
                User usr = await model.login(email,code);
                return StatusCode(200,"01100110");
            }catch (Exception e){
                return StatusCode(400,"the login was not successful");
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> Register(User newUser){
            try {
                User usr = await model.register(newUser);
                return StatusCode(200,usr); //new User());
            }catch (Exception e){
                return StatusCode(400,"registration not successfull");
            }
            
        }
    }

    
}