using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using FleetFlow.Shared.Helpers;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System.Linq.Expressions;

namespace FleetFlow.Service.Services
{
    public class LocationService : ILocationService
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
            var location = await this.unitOfWork.Locations.SelectAsync(x => x.Code.Equals(dto.Code));
            if (location is not null && !location.IsDeleted)
                throw new FleetFlowException(409, "Location already exist");

            var mappedLocation = this.mapper.Map<Location>(dto);
            mappedLocation.CreatedAt = DateTime.UtcNow;
            var addedLocation = await this.unitOfWork.Locations.InsertAsync(mappedLocation);

            await this.unitOfWork.SaveChangesAsync();

            return this.mapper.Map<LocationForResultDto>(addedLocation);

        }

        public async Task<bool> RemoveAsync(long id)
        {
            var location = await this.unitOfWork.Locations.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted) 
                throw new FleetFlowException(404, "Not found");

            await this.unitOfWork.Locations.DeleteAsync(l => l.Id == id);
            location.DeletedBy = HttpContextHelper.UserId;
            await this.unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<LocationForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var locations = this.unitOfWork.Locations.SelectAll()
                                            .Where(l => l.IsDeleted == false)
                                         .ToPagedList(@params).ToList();

            return this.mapper.Map<IEnumerable<LocationForResultDto>>(locations);
        }

        public async Task<LocationForResultDto> RetrieveByIdAsync(long id)
        {
            var location = await this.unitOfWork.Locations.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not Found");

            return this.mapper.Map<LocationForResultDto>(location);
        }

        public async Task<LocationForResultDto> ModifyAsync(long id, LocationForCreationDto dto)
        {
            var location = await this.unitOfWork.Locations.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            var modifiedLocation = this.mapper.Map(dto, location);
            modifiedLocation.UpdatedAt = DateTime.UtcNow;
            modifiedLocation.UpdatedBy = HttpContextHelper.UserId;
            await this.unitOfWork.SaveChangesAsync();

            return this.mapper.Map<LocationForResultDto>(modifiedLocation);
        }
    }
}
