using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class ProductInventoryAssignmentsController : RestfulSense
    {
        private readonly IProductInventoryAssignmentService service;

        public ProductInventoryAssignmentsController(IProductInventoryAssignmentService service)
        {
            this.service = service;
        }
        /// <summary>
        /// Create new ProductInventoryAssigmentsController
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<ActionResult<ProductInventoryAssignmentForResultDto>> PostAsync([FromBody] ProductInventoryAssignmentForCreationDto dto)
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
        public async ValueTask<ActionResult<ProductInventoryAssignment>> PutAsync(long id, [FromBody] ProductInventoryAssignmentForUpdateDto dto)
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
        [HttpGet]
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
        [HttpGet("id")]
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
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetProductByIdAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.RetrieveProductById(id)
            });
        /// <summary>
        /// Delete Quantity
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="InventoryId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpDelete]
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
        [HttpPost]
        public async ValueTask<IActionResult> PostQuantityAsync(long productId, long inventoryId, int amount)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await this.service.AddQuantity(productId, inventoryId, amount)
            });
    }
}
