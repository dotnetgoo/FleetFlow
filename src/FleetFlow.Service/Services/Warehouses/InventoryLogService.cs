using AutoMapper;
using FleetFlow.DAL.Repositories;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Warehouses
{
    public class InventoryLogService : IInventoryLogService
    {
        private readonly Repository<InventoryLog> inventoryRepository;
        private readonly IMapper mapper;

        public InventoryLogService(Repository<InventoryLog> inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<InventoryLogForResultDto> AddAsync(InventoryLogForCreationDto dto)
        {
            var mapped = this.mapper.Map<InventoryLog>(dto);
            await this.inventoryRepository.InsertAsync(mapped);
            await this.inventoryRepository.SaveAsync();
            return this.mapper.Map<InventoryLogForResultDto>(mapped);
        }

        public async Task<IEnumerable<InventoryLogForResultDto>> RetrieveAllByProductId(Filter filter, PaginationParams @params = null)
        {
            if (@params is null)
            {

                var logs = await this.inventoryRepository.SelectAll(x => x.OwnerId == filter.OwnerId  && x.ProductId == filter.ProductId && x.RemovedOrNot == filter.Type).ToListAsync();
                return this.mapper.Map<IEnumerable<InventoryLogForResultDto>>(logs);
            }
            var pagedlogs = await this.inventoryRepository.SelectAll(x => x.OwnerId == filter.OwnerId && x.ProductId == filter.ProductId && x.RemovedOrNot == filter.Type).ToPagedList(@params).ToListAsync();
            return this.mapper.Map<IEnumerable<InventoryLogForResultDto>>(pagedlogs);
        }

 
        public async Task<InventoryLogForResultDto> RetrieveById(long id)
        {
            var log = await this.inventoryRepository.SelectAsync(x => x.Id == id && x.IsDeleted == false);
            return this.mapper.Map<InventoryLogForResultDto>(log);
        }
    }
}