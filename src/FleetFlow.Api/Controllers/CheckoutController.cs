using FleetFlow.Api.Models;
using Microsoft.AspNetCore.Mvc;
using FleetFlow.Api.Extensions;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.DTOs.Attachments;
using FleetFlow.Service.Interfaces.Orders;

namespace FleetFlow.Api.Controllers;

public class CheckoutController : RestfulSense
{
    private readonly ICheckoutService checkoutService;

    public CheckoutController(ICheckoutService checkoutService)
    {
        this.checkoutService = checkoutService;
    }

    [HttpPost("assign-address")]
    public async ValueTask<IActionResult> AssignAddressAsync([FromBody] AddressAddDto addressDto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.checkoutService.AssignAddressAsync(addressDto)
        });


    [HttpPost("payment")]
    public async ValueTask<IActionResult> PayAsync([FromForm] SingleFile file, [FromForm] PaymentCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.checkoutService.PayAsync(dto, await file.File.ToAttachmentAsync())
        });


    [HttpPost("save-order")]
    public async ValueTask<IActionResult> SaveOrderAsync(OrderForCreationDto dto)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.checkoutService.SaveOrderAsync(dto)
        });


    [HttpGet("get-cart-items-list")]
    public async ValueTask<IActionResult> GetAllCartItemsAsync()
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.checkoutService.GetAllCartItemsAsync()
        });


    [HttpGet("last-address")]
    public async ValueTask<IActionResult> GetLastAddressAsync()
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.checkoutService.RetrieveLastAddressAsync()
        });
}
