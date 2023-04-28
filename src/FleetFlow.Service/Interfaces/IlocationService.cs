using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Location;
using System.Linq.Expressions;

namespace FleetFlow.Service.Interfaces
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
