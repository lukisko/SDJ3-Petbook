using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using business_logic.Model;
using business_logic.Model.Mediator;

using System.Text.Json;
using System.Text.Json.Serialization;
using business_logic.Model.PetPack;
using business_logic.Model.UserPack;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorisedUserController :ControllerBase
    {
        private IModel model;
        public AuthorisedUserController(IModel model){
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<AuthorisedUser>> getAuthorisedUser([FromQuery] string token){
            AuthorisedUser user = await model.GetAuthorisedUser(token);
            if (user == null){
                return StatusCode(404,"user with that access token was not found");
            }
            return StatusCode(200,user);
        }
    }
}