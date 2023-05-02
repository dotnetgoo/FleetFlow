using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController, Authorize]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public int FromQuery { get; private set; }

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet, AllowAnonymous]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(await productService.RetrieveAllAsync(@params));


        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id"), AllowAnonymous]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
        {
            return Ok(await productService.RetrieveByIdAsync(id));
        }

        /// <summary>
        /// Create new product
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost, Authorize(Roles = "Admin,Merchant")]
        public async ValueTask<IActionResult> PostAsync([FromBody] ProductForCreationDto dto)
            => Ok(await this.productService.AddAsync(dto));

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<Product>> PutAsync(long id, [FromBody] ProductForCreationDto dto)
        {
            var product = await productService.ModifyAsync(id, dto);
            return Ok(product);
        }

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(await productService.RemoveAsync(id));
    }
}
