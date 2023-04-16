using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Interfaces;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System.Linq.Expressions;

namespace FleetFlow.Service.Services
{
    public class LocationService : IlocationService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public LocationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<LocationForResultDto> AddAsync(LocationForCreationDto dto)
        {
            // Check for exist Address
            var checkLocation = await this.unitOfWork.Locations.SelectAsync(x => x.Code.Equals(dto.Code));
            if (checkLocation is not null)
            {
                throw new FleetFlowException(409, "Location already exist");
            }

            var mapped = this.mapper.Map<Location>(dto);
            var insertResult = await this.unitOfWork.Locations.InsertAsync(mapped);
            await this.unitOfWork.SaveChangesAsync();

            var result = this.mapper.Map<LocationForResultDto>(insertResult);
            return result;
        }

        public async Task<bool> DeleteAsync(Expression<Func<Location, bool>> predicate)
        {
            var CheckLocation = await this.unitOfWork.Locations.SelectAsync(predicate);
            if (CheckLocation is null) throw new FleetFlowException(404, "Not found");

            bool IsDeleted = await this.unitOfWork.Locations.DeleteAsync(predicate);
            await this.unitOfWork.SaveChangesAsync();

            return IsDeleted;
        }

        public async Task<IEnumerable<LocationForResultDto>> GetAllAsync(
            Expression<Func<Location, bool>> predicate = null, string search = null)
        {
            var locations = this.unitOfWork.Locations.SelectAll(predicate);

            var result = mapper.Map<IEnumerable<LocationForResultDto>>(locations);
            if (string.IsNullOrEmpty(search))
                return result
                    .Where(x => x.Code.ToString().Equals(search) || x.Description.Contains(search) || x.Type.Equals(search));
            return result;
        }

        public async Task<LocationForResultDto> GetAsync(Expression<Func<Location, bool>> predicate)
        {
            var location = await this.unitOfWork.Locations.SelectAsync(predicate);
            if (location is null)
                throw new FleetFlowException(404, "Not Found");

            var mapped = this.mapper.Map<LocationForResultDto>(location);
            return mapped;
        }

        public async Task<LocationForResultDto> UpdateAsync(Expression<Func<Location, bool>> predicate, LocationForCreationDto dto)
        {
            var location = await this.unitOfWork.Locations.SelectAsync(predicate);
            if (location is null)
                throw new FleetFlowException(404, "Not found");

            var mapped = this.mapper.Map(dto, location);
            mapped.UpdatedAt = DateTime.UtcNow;
            await this.unitOfWork.SaveChangesAsync();
            return this.mapper.Map<LocationForResultDto>(mapped);
        }
    }
}
