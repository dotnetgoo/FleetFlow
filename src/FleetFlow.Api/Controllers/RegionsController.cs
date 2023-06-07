using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.Interfaces.Commons;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class RegionsController : RestfulSense
{
    private readonly IRegionService regionService;

    public RegionsController(IRegionService regionService)
    {
        this.regionService = regionService;
    }

    [HttpGet("{id:long}")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await regionService.RetrieveAsync(id)
        });

    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await regionService.RetrieveAllAsync(@params)
        });

    [HttpPost]
    public IActionResult Create()
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = regionService.SaveToDatabase()
        });
}