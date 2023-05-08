using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Interfaces;
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

        [HttpPost("items/add")]
        public async ValueTask<IActionResult> AddItemAsync([FromBody] CartItemCreationDto itemDto)
            => Ok(await this.cartService.AddItemAsync(itemDto));

        [HttpDelete("items/{id}")]
        public async ValueTask<IActionResult> DeleteItemAsync([FromRoute(Name = "id")] long itemId)
            => Ok(await this.cartService.RemoveItemAsync(itemId));

        [HttpPut("items/{id}")]
        public async ValueTask<IActionResult> PutItemAsync([FromRoute(Name = "Id")] long itemId, int amount)
            => Ok(await this.cartService.UpdateItemAsync(itemId, amount));
    }
}
