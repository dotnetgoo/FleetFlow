using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.Interfaces.Products
{
    public interface IProductService
    {
        public Task<ProductForResultDto> AddAsync(ProductForCreationDto dto);
        public Task<bool> RemoveAsync(long id);
        public Task<ProductForResultDto> ModifyAsync(long id, ProductForCreationDto dto);
        public Task<IEnumerable<ProductForResultDto>> RetrieveAllAsync(PaginationParams @params);
        public Task<ProductForResultDto> RetrieveByIdAsync(long id);

    }
}
