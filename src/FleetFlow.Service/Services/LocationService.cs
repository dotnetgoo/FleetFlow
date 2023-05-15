using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using Location = FleetFlow.Domain.Entities.Location;

namespace FleetFlow.Service.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> locationRepository;
        private readonly IMapper mapper;

        public LocationService(IMapper mapper, IRepository<Location> locationRepository)
        {
            this.mapper = mapper;
            this.locationRepository = locationRepository;
        }

        public async Task<LocationForResultDto> AddAsync(LocationForCreationDto dto)
        {
            // Check for exist Address
            var location = await this.locationRepository.SelectAsync(x => x.Code.Equals(dto.Code));
            if (location is not null && !location.IsDeleted)
                throw new FleetFlowException(409, "Location already exist");

            var mappedLocation = this.mapper.Map<Location>(dto);
            mappedLocation.CreatedAt = DateTime.UtcNow;
            var addedLocation = await this.locationRepository.InsertAsync(mappedLocation);

            await this.locationRepository.SaveAsync();

            return this.mapper.Map<LocationForResultDto>(addedLocation);

        }

        public async Task<bool> RemoveAsync(long id)
        {
            var location = await this.locationRepository.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted) 
                throw new FleetFlowException(404, "Not found");

            await this.locationRepository.DeleteAsync(l => l.Id == id);
            location.DeletedBy = HttpContextHelper.UserId;
            await this.locationRepository.SaveAsync();

            return true;
        }

        public async Task<IEnumerable<LocationForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var locations = await this.locationRepository.SelectAll()
                .Where(l => !l.IsDeleted)
                .ToPagedList(@params)
                .ToListAsync();

            return this.mapper.Map<IEnumerable<LocationForResultDto>>(locations);
        }

        public async Task<LocationForResultDto> RetrieveByIdAsync(long id)
        {
            var location = await this.locationRepository.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not Found");

            return this.mapper.Map<LocationForResultDto>(location);
        }

        public async Task<LocationForResultDto> ModifyAsync(long id, LocationForCreationDto dto)
        {
            var location = await this.locationRepository.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            var modifiedLocation = this.mapper.Map(dto, location);
            modifiedLocation.UpdatedAt = DateTime.UtcNow;
            modifiedLocation.UpdatedBy = HttpContextHelper.UserId;
            await this.locationRepository.SaveAsync();

            return this.mapper.Map<LocationForResultDto>(modifiedLocation);
        }
    }
}
