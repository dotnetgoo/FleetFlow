using FleetFlow.Service.DTOs.Discounts;

namespace FleetFlow.Service.Interfaces.Products;

public interface IDiscountService
{
    Task<DiscountResultDto> AddAsync(DiscountCreationDto dto);
    Task<DiscountResultDto> ModifyAsync(DiscountUpdateDto dto);
    Task<bool> RemoveAsync(long id);
    Task<DiscountResultDto> RetrieveAsync(long id);
    Task<IEnumerable<DiscountResultDto>> RetrieveAllAsync();
}
