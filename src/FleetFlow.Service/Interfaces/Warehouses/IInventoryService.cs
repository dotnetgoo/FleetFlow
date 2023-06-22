using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Inventories;

namespace FleetFlow.Service.Interfaces.Warehouses
{
    public interface IInventoryService
    {
        Task<InventoryForResultDto> AddAsync(InventoryForCreationDto inventoryCreationDto);
        Task<InventoryForResultDto> RetrieveById(long id);
        Task<InventoryForResultDto> RetrieveByName(string name);
        Task<IEnumerable<InventoryForResultDto>> RetrieveAllInventory(PaginationParams @params = null);
        Task<InventoryForResultDto> ModifyAsync(long id, InventoryForUpdateDto inventoryForUpdateDto);
        Task<bool> RemoveAsync(long id);
    }
}
