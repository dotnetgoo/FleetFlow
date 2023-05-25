using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.Interfaces.Products;

namespace FleetFlow.Service.Services.Products;

public class DiscountService : IDiscountService
{
    public Task<DiscountResultDto> AddAsync(DiscountCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<DiscountResultDto> ModifyAsync(DiscountUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DiscountResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<DiscountResultDto> RetrieveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> StopAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> StopByProductIdAsync(long productId)
    {
        throw new NotImplementedException();
    }
}
