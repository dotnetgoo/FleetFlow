using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Inventories;

namespace FleetFlow.Service.Interfaces.Warehouses
{
    public interface IProductInventoryAssignmentService
    {
        Task<ProductInventoryAssignmentForResultDto> AddAsync(ProductInventoryAssignmentForCreationDto dto);
        Task<ProductInventoryAssignmentForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<ProductInventoryAssignmentForResultDto>> RetrieveAllAsync(PaginationParams @params);
        Task<ProductInventoryAssignmentForResultDto> ModifyAsync(long id, ProductInventoryAssignmentForUpdateDto dto);
        Task<bool> RemoveAsync(long id);
        Task<ProductInventoryAssignmentForResultDto> RemoveQuantity(long ProductId, long InventoryId, int amount);
        Task<ProductInventoryAssignmentForResultDto> AddQuantity(long ProductId, long InventoryId, int amount);
    }
}
