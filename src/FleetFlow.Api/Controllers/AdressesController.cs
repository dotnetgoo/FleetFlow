using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.Interfaces.Addresses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class AdressesController : RestfulSense
{
    private readonly IAddressService addressService;

    public AdressesController(IAddressService addressService)
    {
        this.addressService = addressService;
    }

    /// <summary>
    /// Creates new address
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    [HttpPost]
    public async ValueTask<IActionResult> PostAsync([FromBody] AddressForCreationDto address)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.addressService.AddAsync(address)
        });

    /// <summary>
    /// gets address by its id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.addressService.GetByIdAsync(id)
        });

    /// <summary>
    /// gets all addresses in db in paginated form
    /// </summary>
    /// <param name="params"></param>
    /// <returns></returns>
    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.addressService.GetAllAsync(@params)
        });

    /// <summary>
    /// Update address
    /// </summary>
    /// <param name="id"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public async ValueTask<IActionResult> PutAsync(long id, AddressForCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.addressService.UpdateByIdAsync(id, dto)
        });
}
