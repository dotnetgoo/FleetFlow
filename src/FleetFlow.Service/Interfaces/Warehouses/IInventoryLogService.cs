using FleetFlow.Domain.Configurations;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.InventoryLogs;

namespace FleetFlow.Service.Interfaces.Warehouses
{
    public interface IInventoryLogService
    {
        Task<InventoryLogForResultDto> AddAsync(InventoryLogForCreationDto dto);
        Task<InventoryLogForResultDto> RetrieveById(long id);
        Task<IEnumerable<InventoryLogForResultDto>> RetrieveAllByFiltering(Filter filter, PaginationParams @params = null);
    }
}
