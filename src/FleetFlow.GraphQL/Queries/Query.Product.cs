using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<ProductForResultDto> GetProductByIdAsync([Service] IProductService service, long id)
        {
            return await service.RetrieveByIdAsync(id);
        }
        public async ValueTask<IEnumerable<ProductForResultDto>> GetProductAllAsync([Service] IProductService service, PaginationParams @params)
        {
            return await service.RetrieveAllAsync(@params);
        }
    }
}
