using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;

namespace FleetFlow.Service.Interfaces.Commons;

public interface IDistrictService
{
    ValueTask<DistrictResultDto> RetrieveAsync(long id);
    ValueTask<IEnumerable<DistrictResultDto>> RetrieveAllAsync(PaginationParams @params);
    ValueTask SaveToDatabase();
}
