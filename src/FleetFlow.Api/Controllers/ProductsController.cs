using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.Interfaces.Products;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class ProductsController : RestfulSense
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await productService.RetrieveAllAsync(@params)
            });


        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetAsync(long id)
        {
            return Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await productService.RetrieveByIdAsync(id)
            });
        }

        /// <summary>
        /// Create new product
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromBody] ProductForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.productService.AddAsync(dto)
            });

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<Product>> PutAsync(long id, [FromBody] ProductForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await productService.ModifyAsync(id, dto)
            });

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await productService.RemoveAsync(id)
            });
    }
}
