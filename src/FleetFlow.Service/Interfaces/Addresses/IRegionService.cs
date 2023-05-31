using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Address;

namespace FleetFlow.Service.Interfaces.Orders;

public interface IRegionService
{
    ValueTask<RegionResultDto> RetrieveAsync(long id);
    List<RegionResultDto> RetrieveAllAsync(PaginationParams @params);
}