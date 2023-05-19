using Microsoft.AspNetCore.Mvc;
using FleetFlow.Service.Interfaces;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Payments;

namespace FleetFlow.Api.Controllers;

public class PaymentsController : RestfulSense
{
    private readonly IPaymentService payementService;
    public PaymentsController(IPaymentService payementService)
    {
        this.payementService = payementService;
    }

    [HttpPost]
    public async ValueTask<IActionResult> PostAsync([FromForm] PaymentCreationDto dto)
        => Ok(await this.payementService.AddAsync(dto));


    [HttpPut("id:long")]
    public async ValueTask<IActionResult> PutAsync(long id, PaymentCreationDto dto)
        => Ok(await this.payementService.ModifyAsync(id, dto));


    [HttpDelete("id:long")]
    public async ValueTask<IActionResult> DeleteAsync(long id)
        => Ok(await this.payementService.RemoveAsync(id));


    [HttpGet("id:long")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(await this.payementService.RetrieveByIdAsync(id));


    [HttpGet("get-list")]
    public async ValueTask<IActionResult> GetAllAsync(PaginationParams @params)
        => Ok(await this.payementService.RetrieveAllAsync(@params));
}
