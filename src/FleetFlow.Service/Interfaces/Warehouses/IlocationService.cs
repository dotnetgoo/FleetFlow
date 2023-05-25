using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Location;

namespace FleetFlow.Service.Interfaces.Warehouses
{
    public interface ILocationService
    {
        Task<LocationForResultDto> AddAsync(LocationForCreationDto dto);
        Task<bool> RemoveAsync(long id);
        Task<LocationForResultDto> ModifyAsync(long id, LocationForCreationDto dto);
        Task<LocationForResultDto> RetrieveByIdAsync(long id);
        Task<IEnumerable<LocationForResultDto>> RetrieveAllAsync(PaginationParams @params);
    }
}
