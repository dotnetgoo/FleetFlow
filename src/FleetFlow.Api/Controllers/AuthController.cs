using FleetFlow.Api.Models;
using FleetFlow.Service.DTOs.Login;
using FleetFlow.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class AuthController : RestfulSense
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(LoginDto dto)
        {
            return Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.authService.AuthenticateAsync(dto.Email, dto.Password)
            });
        }

    }
}
