using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.Interfaces.Commons;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class DistrictsController : RestfulSense
{
    private readonly IDistrictService districtService;

    public DistrictsController(IDistrictService districtService)
    {
        this.districtService = districtService;
    }

    [HttpGet("{id:long}")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await districtService.RetrieveAsync(id)
        });

    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await districtService.RetrieveAllAsync(@params)
        });

    [HttpPost]
    public IActionResult Create()
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = districtService.SaveToDatabase()
        });
}