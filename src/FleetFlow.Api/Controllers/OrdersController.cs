using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.Interfaces.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class OrdersController : RestfulSense
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost("order")]
        public async ValueTask<IActionResult> PostAsync()
            => Ok(new Response()
            {
                Code = 200,
                Message = "OK",
                Data = await this.orderService.AddAsync()
            });

        [HttpPost("cancel/{id:long}")]
        public async ValueTask<IActionResult> CancelAsync(long id)
            => Ok(new Response()
            {
                Code = 200,
                Message = "OK",
                Data = await this.orderService.CancelAsync(id)
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
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params,
            [FromQuery] OrderStatus status = OrderStatus.Pending)
        {
            return Ok(new Response()
            {
                Code = 200,
                Message = "OK",
                Data = await this.orderService.RetrieveAllAsync(@params, status)
            });
        }

        [HttpGet("{client-id:long}")]
        public async ValueTask<IActionResult> GetAllByClientIdAsync([FromRoute(Name = "client-id")] long clientId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.orderService.RetrieveAllByClientIdAsync(clientId)
            });

        [HttpGet("phone")]
        public async ValueTask<IActionResult> GetAllByPhoneAsync([FromQuery] PaginationParams @params,
            string phone,
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
}
