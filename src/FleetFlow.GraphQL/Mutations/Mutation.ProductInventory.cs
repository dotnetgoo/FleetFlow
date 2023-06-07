using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<ProductInventoryAssignmentForResultDto> CreateProductInventoryAsync([Service]
        IProductInventoryService service, ProductInventoryAssignmentForCreationDto dto)
        {
            return await service.AddAsync(dto);
        }
        public async ValueTask<ProductInventoryAssignmentForResultDto> UpdateProductInventoryAsync([Service]
        IProductInventoryService service,long id,ProductInventoryAssignmentForUpdateDto dto)
        {
            return await service.ModifyAsync(id,dto);
        }
        public async ValueTask<bool> DeleteProductInventoryAsync([Service] IProductInventoryService service,
            long id)
        {
            return await service.RemoveAsync(id);
        }
        public async ValueTask<ProductInventoryAssignmentForResultDto> CreateQuantityAsync([Service] IProductInventoryService service,
            long productId, long inventoryId, int amount)
        {
            return await service.AddQuantity(productId, inventoryId, amount);
        }
        public async ValueTask<ProductInventoryAssignmentForResultDto> DeleteQuantityAsync([Service] IProductInventoryService service,
           long productId, long inventoryId, int amount)
        {
            return await service.RemoveQuantity(productId, inventoryId, amount);
        }
    }
}
