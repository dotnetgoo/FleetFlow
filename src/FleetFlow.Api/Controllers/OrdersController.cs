using FleetFlow.Domain.Congirations;
using FleetFlow.Service.Interfaces;
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

        [HttpPost, Authorize]
        public async ValueTask<IActionResult> PostAsync()
            => Ok(await this.orderService.AddAsync());

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery]PaginationParams @params)
            => Ok(await this.orderService.);
    }
}
