using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entities;
using business_logic.Model;
using business_logic.Model.Login;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorisedUserController :ControllerBase
    {
        private IAuthorisedUserControl model;
        private IPetControl petControl;
        private IUserControl userControl;
        private ILoginManager loginManager;
        public AuthorisedUserController(IPetControl petControl,IUserControl userControl,ILoginManager loginManager){
            this.petControl = petControl;
            this.userControl = userControl;
            this.loginManager = loginManager;
        }

        [HttpGet]
        public async Task<ActionResult<Entities.AuthorisedUser>> getAuthorisedUser([FromQuery] string token){
            string email = loginManager.getUserWithToken(token);
            if (email == null){
                return StatusCode(404,"user with that access token was not found");
            }
            Entities.AuthorisedUser user = await userControl.GetUser(email);
            user.pets = (await petControl.getPetsAsync(null,email,null,null,null,null,null,null)).ToArray();
            
            return StatusCode(200,user);
        }
    }
}