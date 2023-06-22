using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers;

public class OrdersController : RestfulSense
{
    private readonly IOrderService orderService;
    public OrdersController(IOrderService orderService)
    {
        this.orderService = orderService;
    }

    [HttpPost("order")]
    public async ValueTask<IActionResult> PostAsync([FromBody] OrderForCreationDto dto)
        => Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.orderService.AddAsync(dto)
        });


    [HttpDelete("id")]
    public async ValueTask<IActionResult> DeleteAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.orderService.RemoveAsync(id)
        });


    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync(
        [FromQuery] PaginationParams @params,
        [FromQuery] OrderStatus? status = null)
        => Ok(new Response()
        {
            Code = 200,
            Message = "OK",
            Data = await this.orderService.RetrieveAllAsync(@params, status)
        });


    [HttpGet("{client-id:long}")]
    public async ValueTask<IActionResult> GetAllByClientIdAsync([FromRoute(Name = "client-id")] long clientId)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.orderService.RetrieveAllByClientIdAsync(clientId)
        });


    [HttpGet("phone")]
    public async ValueTask<IActionResult> GetAllByPhoneAsync(
        string phone,
        [FromQuery] PaginationParams @params,
        [FromQuery] OrderStatus? status = null)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.orderService.RetrieveAllByPhoneAsync(@params, phone, status)
        });


    [HttpGet("id")]
    public async ValueTask<IActionResult> GetAsync(long id)
        => Ok(new Response
        {
            Code = 200,
            Message = "OK",
            Data = await this.orderService.RetrieveAsync(id)
        });
}
