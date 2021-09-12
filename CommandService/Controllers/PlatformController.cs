using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [ApiController]
    [Route("api/command/[controller]")]
    public class PlatformController : ControllerBase
    {
        public PlatformController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound Post # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}