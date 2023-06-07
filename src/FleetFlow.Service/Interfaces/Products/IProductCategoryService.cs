using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Products;

namespace FleetFlow.Service.Interfaces.Products;

public interface IProductCategoryService
{
    Task<ProductCategoryResultDto> AddAsync(ProductCategoryCreationDto dto);
    Task<ProductCategoryResultDto> ModifyAsync(long id, ProductCategoryUpdateDto dto);
    Task<bool> RemoveAsync(long id);
    Task<ProductCategoryResultDto> RetrieveAsync(long id);
    Task<IEnumerable<ProductCategoryResultDto>> RetrieveAllAsync(PaginationParams @params);
}
