using FleetFlow.Api.Models;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class CartsController : RestfulSense
    {
        private readonly ICartService cartService;

        public CartsController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        [HttpPost("items/add"), Authorize]
        public async ValueTask<IActionResult> AddItemAsync([FromBody] CartItemCreationDto itemDto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.AddItemAsync(itemDto)
            });

        [HttpDelete("items/{id}")]
        public async ValueTask<IActionResult> DeleteItemAsync([FromRoute(Name = "id")] long itemId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.RemoveItemAsync(itemId)
            });

        [HttpPut("items/{id}")]
        public async ValueTask<IActionResult> PutItemAsync([FromRoute(Name = "Id")] long itemId, int amount)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.UpdateItemAsync(itemId, amount)
            });
    }
}
