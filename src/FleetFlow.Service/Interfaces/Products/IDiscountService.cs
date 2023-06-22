using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Discounts;

namespace FleetFlow.Service.Interfaces.Products;

public interface IDiscountService
{
    Task<DiscountResultDto> AddAsync(DiscountCreationDto dto);
    Task<DiscountResultDto> ModifyAsync(long id, DiscountUpdateDto dto);
    Task<DiscountResultDto> RetrieveAsync(long id);
    Task<IEnumerable<DiscountResultDto>> RetrieveAllAsync(PaginationParams @params, DiscountState? state = null);


    Task<bool> StopAsync(long id);
    Task<bool> StopByProductIdAsync(long productId);

}
