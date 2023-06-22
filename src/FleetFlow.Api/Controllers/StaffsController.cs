using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Staffs;
using FleetFlow.Service.Interfaces.Staffs;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class StaffsController : RestfulSense
    {
        private IStaffService staffService;

        public StaffsController(IStaffService staffService)
        {
            this.staffService = staffService;
        }


        /// <summary>
        /// Add Staff
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync([FromBody] StaffForCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await staffService.AddAsync(dto)
        });
        /// <summary>
        /// Modify Staff
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(long id, [FromBody] StaffForUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await staffService.ModifyAsync(id, dto)
            });
        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await staffService.RemoveAsync(id)
            });

        /// <summary>
        /// Get by id Staff
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await staffService.RetrieveByIdAsync(id)
            });
        /// <summary>
        /// Get all Staff
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await staffService.RetrieveAllAsync(@params)
            });
        /// <summary>
        /// Get by role id
        /// </summary>
        /// <param name="params"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet("roleId")]
        public async ValueTask<IActionResult> GetByRoleId([FromQuery] PaginationParams @params, long roleId)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await staffService.RetrieveAllByRoleAsync(@params, roleId)
            });
        /// <summary>
        /// Get by UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("userId")]
        public async ValueTask<IActionResult> GetByUserId(long userId)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await staffService.RetrieveByUserIdAsync(userId)
            });

    }
}
