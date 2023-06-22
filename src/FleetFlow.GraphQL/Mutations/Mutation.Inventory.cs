using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<InventoryForResultDto> CreateInventoryAsync([Service] IInventoryService inventoryService,
            InventoryForCreationDto inventory)
        {
            return await inventoryService.AddAsync(inventory);
        }
        public async ValueTask<InventoryForResultDto> UpdateInventoryAsync([Service] IInventoryService inventoryService,
            long id,
            InventoryForUpdateDto inventory)
        {
            return await inventoryService.ModifyAsync(id, inventory);
        }
        public async ValueTask<bool> DeleteInventoryAsync([Service] IInventoryService inventoryService, long id)
        {
            return await inventoryService.RemoveAsync(id);
        }

    }
}
