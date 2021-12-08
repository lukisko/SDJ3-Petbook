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
    public class MessageController : ControllerBase
    {
        private IModel model;
        public MessageController(IModel model)
        {
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Message>>> GetMessages([FromQuery] int receiverPetId, [FromQuery] int? senderPetId, [FromQuery] string token)
        {
            if (senderPetId == null)
            {
                try
                {
                    return StatusCode(201, await model.GetMessagePets(receiverPetId, token));
                }
                catch (AccessViolationException e)
                {
                    return StatusCode(401, e.Message);
                }
            }
            else
            {
                try
                {
                    return StatusCode(201, await model.GetMessages(receiverPetId, (int)senderPetId, token));
                }
                catch (AccessViolationException e)
                {
                    return StatusCode(401, e.Message);
                }
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> SendMessage([FromQuery] string token, Message message)
        {
            try
            {
                await model.sendMessage(message, token);
                return StatusCode(201);
            }
            catch (AccessViolationException e)
            {
                return StatusCode(401, e.Message);
            }
        }
    }
}