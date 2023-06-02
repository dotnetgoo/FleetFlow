using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;

namespace FleetFlow.Service.Interfaces.Commons;

public interface IRegionService
{
    ValueTask<RegionResultDto> RetrieveAsync(long id);
    Task<IEnumerable<RegionResultDto>> RetrieveAllAsync(PaginationParams @params);
    ValueTask SaveToDatabase();
}