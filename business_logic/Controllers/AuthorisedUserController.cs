using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entities;
using business_logic.Model;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorisedUserController :ControllerBase
    {
        private IAuthorisedUserControl model;
        public AuthorisedUserController(IModel model){
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<Entities.AuthorisedUser>> getAuthorisedUser([FromQuery] string token){
            Entities.AuthorisedUser user = await model.GetAuthorisedUser(token);
            if (user == null){
                return StatusCode(404,"user with that access token was not found");
            }
            return StatusCode(200,user);
        }
    }
}