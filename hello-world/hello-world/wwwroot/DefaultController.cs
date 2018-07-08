namespace hello_world.wwwroot
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [Route("hello-world")]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello World");
        }
    }
}