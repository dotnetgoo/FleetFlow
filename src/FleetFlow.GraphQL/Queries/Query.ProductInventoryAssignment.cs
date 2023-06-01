using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<ProductInventoryAssignmentForResultDto> GetProductInventoryAssignmentById([Service]
        IProductInventoryService service,long id)
        {
            return await service.RetrieveByIdAsync(id);
        }
        public async ValueTask<IEnumerable<ProductInventoryAssignmentForResultDto>> GetAllProductInventoryAssignment(
            [Service]IProductInventoryService service,PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
        public async ValueTask<IEnumerable<ProductInventoryAssignmentForResultDto>> GetProductByIdAsync([Service]
        IProductInventoryService service,long id)
        {
            return await service.RetrieveProductById(id);
        }
    }
}
