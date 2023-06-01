using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IDistrictService
{
    ValueTask<DistrictResultDto> RetrieveAsync(long id);
    ValueTask<IEnumerable<DistrictResultDto>> RetrieveAllAsync(PaginationParams @params);
}
