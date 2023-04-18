using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController]
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
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery]PaginationParams @params)
        {
            return Ok(await userService.GetAllAsync(@params));
        }

        /// <summary>
        /// Get by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(await userService.GetAsync(u => u.Id == id));

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<ActionResult<UserForResultDto>> PostAsync(UserForCreationDto dto)
            => Ok(await userService.AddAsync(dto));

        /// <summary>
        /// Update user info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("Id")]
        public async ValueTask<ActionResult<UserForResultDto>> PutAsync(long id, UserForCreationDto dto)
            => Ok(await userService.UpdateAsync(u => u.Id == id, dto));

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(await userService.DeleteAsync(u => u.Id == id));
    }
}