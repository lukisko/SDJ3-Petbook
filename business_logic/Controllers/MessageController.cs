using System;
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

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController :ControllerBase
    {
        private IModel model;
        public MessageController(IModel model){
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Message>>> GetMessages([FromQuery] string token){
            return StatusCode(501,"not implemented geting of messages with a person");
        }

        [HttpPost]
        public async Task<ActionResult<string>> SendMessage([FromQuery] string token, Message message){
            return StatusCode(501,"not implemented, sorry");
        }
    }
}