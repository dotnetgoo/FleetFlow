using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;
using FleetFlow.Service.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class DiscountsController : RestfulSense
    {
        private readonly IDiscountService discountService;
        public DiscountsController(IDiscountService discountService)
        {
            this.discountService = discountService;
        }

        [HttpPost("discount")]
        public async Task<IActionResult> PostAsync(DiscountCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.AddAsync(dto)
            });

        [HttpPut("discount")]
        public async Task<IActionResult> PutAsync(DiscountUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.ModifyAsync(dto)
            });

        [HttpGet("id")]
        public async Task<IActionResult> GetAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.RetrieveAsync(id)
            });

        [HttpGet("discounts")]
        public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params, DiscountState? status = null)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.RetrieveAllAsync(@params, status)
            });

        [HttpPut("stop")]
        public async Task<IActionResult> StopAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.StopAsync(id)
            });

        [HttpPut("stop - productId")]
        public async Task<IActionResult> StopByProductIdAsync(long productId)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.StopByProductIdAsync(productId)
            });
    }
}
