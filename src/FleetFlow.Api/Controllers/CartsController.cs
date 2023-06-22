using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.Interfaces.Orders;
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

        [HttpPut("items/id")]
        public async ValueTask<IActionResult> PutItemAsync(CartItemUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.ModifyItemAsync(dto)
            });

        [HttpGet("items")]
        public async ValueTask<IActionResult> GetAll([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.RetrieveAllAsync(@params)
            });

        [HttpGet("items/{id}")]
        public async ValueTask<IActionResult> GetItemByItemIdAsync([FromRoute(Name = "id")] long itemId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.RetrieveByItemIdAsync(itemId)
            });

        [HttpGet("items/get/clientId")]
        public async ValueTask<IActionResult> GetItembyClientIdAsync()
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.cartService.RetrieveByClientIdAsync()
            });
    }
}
