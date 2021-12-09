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
using business_logic.Model.RequestPack;

namespace business_logic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private IModel model;

        public RequestController(IModel model){
            this.model = model;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Request>>> getMyRequests([FromQuery] int? userId, [FromQuery] int petId, [FromQuery] string token){
            return StatusCode(501,"not implemented");
        }

        [HttpPost]
        public async Task<ActionResult<string>> sendRequest([FromQuery] string token, Request request){
            return StatusCode(501,"not implemented");
        }
        
    }
}