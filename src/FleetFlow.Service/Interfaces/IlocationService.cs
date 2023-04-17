using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using System.Linq.Expressions;

namespace FleetFlow.Service.Interfaces
{
    public interface IlocationService
    {
        Task<LocationForResultDto> AddAsync(LocationForCreationDto address);
        Task<bool> DeleteAsync(Expression<Func<Location, bool>> predicate);
        Task<LocationForResultDto> UpdateAsync(Expression<Func<Location, bool>> predicate, LocationForCreationDto dto);
        Task<LocationForResultDto> GetAsync(Expression<Func<Location, bool>> predicate);
        Task<IEnumerable<LocationForResultDto>> GetAllAsync(Expression<Func<Location, bool>> predicate = null, string search = null);
    }
}
