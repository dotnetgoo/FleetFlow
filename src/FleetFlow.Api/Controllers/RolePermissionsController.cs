using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.RolePermissions;
using FleetFlow.Service.Interfaces.Authorizations;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class RolePermissionsController : RestfulSense
    {
        private readonly IRolePermissionService rolePermissionService;

        public RolePermissionsController(IRolePermissionService rolePermissionService)
        {
            this.rolePermissionService = rolePermissionService;
        }
        //Task<RolePermissionForResultDto> CreateAsync(RolePermissionForCreateDto permission);
        //Task<RolePermissionForResultDto> ModifyAsync(RolePermissionForUpdateDto permission);
        //Task<bool> DeleteAsync(long id);
        //Task<RolePermissionForResultDto> RetrieveByIdAsync(long id);
        //Task<List<RolePermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);
        //Task<List<RolePermissionForResultDto>> RetrieveAllPermissionsByRole(long roleId, string role);

        [HttpPost]
        public async Task<IActionResult> PostAsync(RolePermissionForCreateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.rolePermissionService.CreateAsync(dto)
            });

        [HttpPut]
        public async Task<IActionResult> PutAsync(RolePermissionForUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.rolePermissionService.ModifyAsync(dto)
            });
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.rolePermissionService.RemoveAsync(id)
            });

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.rolePermissionService.RetrieveByIdAsync(id)
            });

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
           => Ok(new Response
           {
               Code = 200,
               Message = "OK",
               Data = await this.rolePermissionService.RetrieveAllAsync(@params)
           });

    }
}
