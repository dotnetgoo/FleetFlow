using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Interfaces;
using FleetFlow.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
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
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var products = await productService.GetAllAsync();
            return Ok(products);
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
        {
            return Ok(await productService.GetByIdAsync(product => product.Id == id));
        }

        /// <summary>
        /// Create new product
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromBody] ProductCreationDto dto)
        {
            var createdProduct = await productService.CreatAsync(dto);
            return Ok(createdProduct);
        }

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("Id")]
        public async ValueTask<ActionResult<Product>> PutAsync(long id, [FromBody] ProductCreationDto dto)
        {
            var product = await productService.UpdateAsync(product => product.Id == id, dto);
            return Ok(product);
        }

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(await productService.DeleteAsync(product => product.Id == id));
    }
}
