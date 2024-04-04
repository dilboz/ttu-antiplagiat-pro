using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Ping
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        //get ping api
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Pong");
        }
    }
}
