using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<InventoryForResultDto> GetInventoryByIdAsync([Service] IInventoryService inventoryService, long id)
        {
            return await inventoryService.RetrieveById(id);
        }

        public async ValueTask<IEnumerable<InventoryForResultDto>> GetAllInventorysAsync([Service] IInventoryService inventoryService,
            PaginationParams @params)
        {
            return await inventoryService.RetrieveAllInventory(@params);
        }
    }
}
