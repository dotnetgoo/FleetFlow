using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Roles;
using FleetFlow.Service.Interfaces.Authorizations;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class RolesController : RestfulSense
{
    private readonly IRoleService roleService;

    public RolesController(IRoleService roleService)
    {
        this.roleService = roleService;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(RoleCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.roleService.AddAsync(dto)
        });

    [HttpPut]
    public async Task<IActionResult> PutAsync(RoleUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.roleService.ModifyAsync(dto)
        });

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.roleService.RemoveAsync(id)
        });

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.roleService.RetrieveByIdAsync(id)
        });

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
      => Ok(new Response
      {
          Code = 200,
          Message = "OK",
          Data = await this.roleService.RetrieveAllAsync(@params)
      });
    [HttpPut("assign-role")]
    public async Task<IActionResult> AssignRoleForUser(long userId, long roleId)
        => Ok(new Response
        {
            Code = 200,
            Message = "Ok",
            Data = await this.roleService.AssignRoleForUserAsync(userId, roleId)
        });
}
