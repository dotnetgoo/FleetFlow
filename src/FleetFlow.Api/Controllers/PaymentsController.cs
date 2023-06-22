using FleetFlow.Api.Extensions;
using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class PaymentsController : RestfulSense
{
    private readonly IPaymentService payementService;
    public PaymentsController(IPaymentService payementService)
    {
        this.payementService = payementService;
    }

    [HttpPost]
    public async ValueTask<IActionResult> PostAsync([FromForm] SingleFile file, [FromForm] PaymentCreationDto dto)
    {
        return Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.payementService.AddAsync(dto, await file.File.ToAttachmentAsync())
        });
    }

    [HttpPut("{id:long}")]
    public async ValueTask<IActionResult> PutAsync(long id, PaymentCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.payementService.ModifyAsync(id, dto)
        });


    [HttpDelete("{id:long}")]
    public async ValueTask<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.payementService.RemoveAsync(id)
        });


    [HttpGet("{id:long}")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.payementService.RetrieveByIdAsync(id)
        });


    [HttpGet("get-list")]
    public async ValueTask<IActionResult> GetAllAsync(PaginationParams @params)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.payementService.RetrieveAllAsync(@params)
        });
}
