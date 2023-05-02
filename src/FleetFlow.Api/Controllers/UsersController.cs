using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Merchant;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController, Authorize]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet, Authorize("Administration")]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await userService.RetrieveAllAsync(@params));

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(await userService.RetrieveByIdAsync(id));

        /// <summary>
        /// Create new users
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost, AllowAnonymous]  
        public async ValueTask<ActionResult<UserForResultDto>> PostAsync(UserForCreationDto dto)
            => Ok(await userService.AddAsync(dto));

        /// <summary>
        /// Update users info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<UserForResultDto>> PutAsync(long id, UserForUpdateDto dto)
            => Ok(await userService.ModifyAsync(id, dto));

        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(await userService.RemoveAsync(id));

        /// <summary>
        /// Change user password
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("change-password")]
        public async ValueTask<ActionResult<UserForResultDto>> ChangePasswordAsync(UserForChangePasswordDto dto)
            => Ok(await userService.ChangePasswordAsync(dto));  
    }
}