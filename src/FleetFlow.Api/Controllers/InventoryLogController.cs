using FleetFlow.Api.Models;
using FleetFlow.Domain.Configurations;
using FleetFlow.Domain.Congirations;
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
        [HttpPost]
        public async ValueTask<ActionResult<InventoryLogForResultDto>> PostAsync(InventoryLogForCreationDto dto)
            => Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this._inventoryLogService.AddAsync(dto)
            });

        [HttpGet("id")]
        public async ValueTask<IActionResult> GetByIdAsync(long id) =>
            Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this._inventoryLogService.RetrieveById(id)
            });
        [HttpGet]
        public async ValueTask<IActionResult> GetAllByFilteringAsync([FromQuery] Filter filter, [FromQuery] PaginationParams @params = null) =>
            Ok(new Response
            {
                Code = 200,
                Message = "Ok",
                Data = await this._inventoryLogService.RetrieveAllByFiltering(filter, @params)
            });
    }
}
