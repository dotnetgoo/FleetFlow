using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async ValueTask<ProductForResultDto> CreateProductAsync([Service] IProductService productService,
            ProductForCreationDto product)
        {
            return await productService.AddAsync(product);
        }

        public async ValueTask<bool> DeleteProductAsync([Service] IProductService productService,
            long id)
        {
            return await productService.RemoveAsync(id);
        }

        public async ValueTask<ProductForResultDto> UpdateProductAsync([Service] IProductService productService,
            long id,
            ProductForCreationDto product)
        {
            return await productService.ModifyAsync(id, product);
        }
    }
}