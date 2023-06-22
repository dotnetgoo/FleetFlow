using FleetFlow.Api.Models;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class InventoriesController : RestfulSense
    {
        private readonly IInventoryService service;

        public InventoriesController(IInventoryService service)
        {
            this.service = service;
        }
        /// <summary>
        /// Create new inventories
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async ValueTask<ActionResult<InventoryForResultDto>> PostAsync([FromBody] InventoryForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.AddAsync(dto)
            });
        /// <summary>
        /// Update inventory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async ValueTask<ActionResult<Inventory>> PutAsync(long id, [FromBody] InventoryForUpdateDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.ModifyAsync(id, dto)
            });
        /// <summary>
        /// Delete inventoty by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async ValueTask<ActionResult<bool>> DeleteAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.RemoveAsync(id)
            });
        /// <summary>
        /// Get all Inventory
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.RetrieveAllInventory(@params)
            });
        /// <summary>
        /// Get by id inventory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.RetrieveById(id)
            });
        /// <summary>
        /// Get by name inventory
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("name")]
        public async ValueTask<IActionResult> GetByName(string name)
            => Ok(new Response
            {
                Code = 200,
                Message = "OK",
                Data = await service.RetrieveByName(name)
            });

    }
}
