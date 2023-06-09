using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class ProductInventorysController : RestfulSense
    {
        private readonly IProductInventoryService service;

        public ProductInventorysController(IProductInventoryService service)
        {
            this.service = service;
        }
        /// <summary>
        /// Create new ProductInventoryAssigmentsController
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("add-product")]
        public async ValueTask<ActionResult<ProductInventoryResultDto>> PostAsync([FromBody] ProductInventoryCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.AddAsync(dto)
            });
        /// <summary>
        /// Delete by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(int id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.RemoveAsync(id)
            });
        /// <summary>
        /// Update for ProductInventoryAssignment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<ProductInventory>> PutAsync([FromRoute] long id, [FromBody] ProductInventoryUpdateDto dto)
           => Ok(new Response
           {
               Code = 200,
               Message = "OK",
               Data = await this.service.ModifyAsync(id, dto)
           });
        /// <summary>
        /// Get all ProductInventoryassignment
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet("get-all")]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.RetrieveAllAsync(@params)

            });
        /// <summary>
        /// Get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get-by-id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.RetrieveByIdAsync(id)
            });
        /// <summary>
        /// Get by id Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get-product-by-id")]
        public async ValueTask<IActionResult> GetProductByIdAsync(long productId)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.RetrieveProductById(productId)
            });
        /// <summary>
        /// Delete Quantity
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="InventoryId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpPost("decrement-quantity")]
        public async ValueTask<IActionResult> DeleteQuantityAsync(long productId, long inventoryId, int amount)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.RemoveQuantity(productId, inventoryId, amount)
            });
        /// <summary>
        /// Add Quantity
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="InventoryId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpPost("increase-quantity")]
        public async ValueTask<IActionResult> PostQuantityAsync(long productId, long inventoryId, int amount)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.AddQuantity(productId, inventoryId, amount)
            });
    }
}
