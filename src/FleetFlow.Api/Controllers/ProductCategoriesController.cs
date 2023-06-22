using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Products;
using FleetFlow.Service.Interfaces.Products;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class ProductCategoriesController : RestfulSense
    {
        private readonly IProductCategoryService productCategoryService;
        public ProductCategoriesController(IProductCategoryService productCategory)
        {
            this.productCategoryService = productCategory;
        }

        [HttpPost("product-category")]
        public async ValueTask<IActionResult> PostAsync(ProductCategoryCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this.productCategoryService.AddAsync(dto)
            });

        [HttpPut("product-category")]
        public async ValueTask<IActionResult> PutAsync([FromQuery] long id, ProductCategoryUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this.productCategoryService.ModifyAsync(id, dto)
            });

        [HttpDelete("product-category")]
        public async ValueTask<IActionResult> DeleteAsync([FromQuery] long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this.productCategoryService.RemoveAsync(id)
            });

        [HttpGet("product-category")]
        public async ValueTask<IActionResult> GetAsync([FromQuery] long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this.productCategoryService.RetrieveAsync(id)
            });

        [HttpGet("product-categories")]
        public async ValueTask<IActionResult> GetAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this.productCategoryService.RetrieveAllAsync(@params)
            });
    }
}
