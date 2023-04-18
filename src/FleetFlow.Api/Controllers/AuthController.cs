using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IUserService userService;
        private readonly IAuthService authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            this.userService = userService;
            this.authService = authService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> LoginAsync(UserForLoginDto dto)
            => Ok(await authService.AuthenticateAsync(dto));
    }
}