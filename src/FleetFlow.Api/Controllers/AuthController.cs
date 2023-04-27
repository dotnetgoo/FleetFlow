using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(string username, string password)
        {
            return Ok(await this._authService.GenerateTokenAsync(username, password));
            
        }
    }
}
