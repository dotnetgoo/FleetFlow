using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;
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

        [HttpPost("create")]
        public async Task<IActionResult> PostAsync(DiscountCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.AddAsync(dto)
            });

        [HttpPut("update")]
        public async Task<IActionResult> PutAsync(long id, DiscountUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.ModifyAsync(id, dto)
            });

        [HttpGet("{id:long}")]
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

        [HttpPut("stop/{id:long}")]
        public async Task<IActionResult> StopAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.StopAsync(id)
            });

        [HttpPut("stop/{productId:long}")]
        public async Task<IActionResult> StopByProductIdAsync(long productId)
            => Ok(new Response
            {
                Code = 200,
                Message = "Success",
                Data = await this.discountService.StopByProductIdAsync(productId)
            });
    }
}
