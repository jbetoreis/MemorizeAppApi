using Microsoft.AspNetCore.Mvc;

namespace MemorizeAppApi.Controllers{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase{
        [HttpGet("")]
        public IActionResult GetStatus(){
            return Ok();
        }
    }
}