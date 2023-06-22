using FleetFlow.Api.Attributes;
using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.User;
using FleetFlow.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class UsersController : RestfulSense
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
    [HttpGet]
    [CustomAuthorize]
    public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await userService.RetrieveAllAsync(@params)
        });

    /// <summary>
    /// Get by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("id")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await userService.RetrieveByIdAsync(id)
        });

    /// <summary>
    /// Create new users
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost]
    public async ValueTask<ActionResult<UserForResultDto>> PostAsync(UserForCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await userService.AddAsync(dto)
        });

    /// <summary>
    /// Update users info
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPut("id")]
    public async ValueTask<ActionResult<UserForResultDto>> PutAsync(long id, UserForUpdateDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await userService.ModifyAsync(id, dto)
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
            Message = "OK",
            Data = await userService.RemoveAsync(id)
        });

    /// <summary>
    /// Change user password
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPut("change-password")]
    public async ValueTask<ActionResult<UserForResultDto>> ChangePasswordAsync(UserForChangePasswordDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await userService.ChangePasswordAsync(dto)
        });
}