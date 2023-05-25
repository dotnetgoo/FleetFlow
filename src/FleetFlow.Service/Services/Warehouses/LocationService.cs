using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Warehouses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using Location = FleetFlow.Domain.Entities.Warehouses.Location;

namespace FleetFlow.Service.Services.Warehouses
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
            var location = await locationRepository.SelectAsync(x => x.Code.Equals(dto.Code));
            if (location is not null && !location.IsDeleted)
                throw new FleetFlowException(409, "Location already exist");

            var mappedLocation = mapper.Map<Location>(dto);
            mappedLocation.CreatedAt = DateTime.UtcNow;
            var addedLocation = await locationRepository.InsertAsync(mappedLocation);

            await locationRepository.SaveAsync();

            return mapper.Map<LocationForResultDto>(addedLocation);

        }

        public async Task<bool> RemoveAsync(long id)
        {
            var location = await locationRepository.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            await locationRepository.DeleteAsync(l => l.Id == id);
            location.DeletedBy = HttpContextHelper.UserId;
            await locationRepository.SaveAsync();

            return true;
        }

        public async Task<IEnumerable<LocationForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var locations = await locationRepository.SelectAll()
                .Where(l => !l.IsDeleted)
                .ToPagedList(@params)
                .ToListAsync();

            return mapper.Map<IEnumerable<LocationForResultDto>>(locations);
        }

        public async Task<LocationForResultDto> RetrieveByIdAsync(long id)
        {
            var location = await locationRepository.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not Found");

            return mapper.Map<LocationForResultDto>(location);
        }

        public async Task<LocationForResultDto> ModifyAsync(long id, LocationForCreationDto dto)
        {
            var location = await locationRepository.SelectAsync(l => l.Id == id);
            if (location is null || location.IsDeleted)
                throw new FleetFlowException(404, "Not found");

            var modifiedLocation = mapper.Map(dto, location);
            modifiedLocation.UpdatedAt = DateTime.UtcNow;
            modifiedLocation.UpdatedBy = HttpContextHelper.UserId;
            await locationRepository.SaveAsync();

            return mapper.Map<LocationForResultDto>(modifiedLocation);
        }
    }
}
