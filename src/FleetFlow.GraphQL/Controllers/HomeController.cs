using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.GraphQL.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Hello World");
    }
}