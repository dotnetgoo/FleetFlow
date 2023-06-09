using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Inventories;

namespace FleetFlow.Service.Interfaces.Warehouses
{
    public interface IProductInventoryService
    {
        Task<ProductInventoryResultDto> AddAsync(ProductInventoryCreationDto dto);
        Task<ProductInventoryResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<ProductInventoryResultDto>> RetrieveProductById(long ProductId);
        Task<IEnumerable<ProductInventoryResultDto>> RetrieveAllAsync(PaginationParams @params);
        Task<ProductInventoryResultDto> ModifyAsync(long id, ProductInventoryUpdateDto dto);
        Task<bool> RemoveAsync(long id);
        Task<ProductInventoryResultDto> RemoveQuantity(long ProductId, long InventoryId, int amount);
        Task<ProductInventoryResultDto> AddQuantity(long ProductId, long InventoryId, int amount);
    }
}
