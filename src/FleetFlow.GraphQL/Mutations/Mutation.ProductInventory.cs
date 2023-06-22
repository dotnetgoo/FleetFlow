using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<ProductInventoryResultDto> CreateProductInventoryAsync([Service]
        IProductInventoryService service, ProductInventoryCreationDto dto)
        {
            return await service.AddAsync(dto);
        }
        public async ValueTask<ProductInventoryResultDto> UpdateProductInventoryAsync([Service]
        IProductInventoryService service, long id, ProductInventoryUpdateDto dto)
        {
            return await service.ModifyAsync(id, dto);
        }
        public async ValueTask<bool> DeleteProductInventoryAsync([Service] IProductInventoryService service,
            long id)
        {
            return await service.RemoveAsync(id);
        }
        public async ValueTask<ProductInventoryResultDto> CreateQuantityAsync([Service] IProductInventoryService service,
            long productId, long inventoryId, int amount)
        {
            return await service.AddQuantity(productId, inventoryId, amount);
        }
        public async ValueTask<ProductInventoryResultDto> DeleteQuantityAsync([Service] IProductInventoryService service,
           long productId, long inventoryId, int amount)
        {
            return await service.RemoveQuantity(productId, inventoryId, amount);
        }
    }
}
