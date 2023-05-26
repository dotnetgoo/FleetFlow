using FleetFlow.Domain.Configurations;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class InventoryLogController : RestfulSense
    {
        private readonly IInventoryLogService _inventoryLogService;

        public InventoryLogController(IInventoryLogService inventoryLogService)
        {
            _inventoryLogService = inventoryLogService;
        }
        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id) =>
            Ok(await this._inventoryLogService.RetrieveById(id));
        [HttpGet]
        public async ValueTask<IActionResult> GetAllByFilteringAsync([FromQuery]Filter filter, [FromBody]PaginationParams @params = null) =>
            Ok(await this._inventoryLogService.RetrieveAllByFiltering(filter, @params));
    }
}
