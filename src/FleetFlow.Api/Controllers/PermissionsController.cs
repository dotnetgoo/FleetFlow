using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.Interfaces.Authorizations;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class PermissionsController : RestfulSense
    {
        private readonly IPermissionService permissionService;

        public PermissionsController(IPermissionService permissionService)
        {
            this.permissionService = permissionService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(PermissionForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.permissionService.CreateAsync(dto)
            });

        [HttpPut]
        public async Task<IActionResult> PutAsync(PermissionForUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.permissionService.ModifyAsync(dto)
            });


        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.permissionService.RemoveAsync(id)
            });

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(long id)
          => Ok(new Response
          {
              Code = 200,
              Message = "OK",
              Data = await this.permissionService.RetrieveByIdAsync(id)
          });

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
          => Ok(new Response
          {
              Code = 200,
              Message = "OK",
              Data = await this.permissionService.RetrieveAllAsync(@params)
          });
    }
}
