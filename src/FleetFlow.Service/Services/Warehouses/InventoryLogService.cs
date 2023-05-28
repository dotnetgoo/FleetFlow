using AutoMapper;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Configurations;
using FleetFlow.Domain.Congirations;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.Exceptions;
using FleetFlow.Service.Extentions;
using FleetFlow.Service.Interfaces.Warehouses;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.Service.Services.Warehouses
{
    public class InventoryLogService : IInventoryLogService
    {
        private readonly IRepository<InventoryLog> inventoryRepository;
        private readonly IMapper mapper;

        public InventoryLogService(IRepository<InventoryLog> inventoryRepository, IMapper mapper)
        {
            this.inventoryRepository = inventoryRepository;
            this.mapper = mapper;
        }

        public async Task<InventoryLogForResultDto> AddAsync(InventoryLogForCreationDto dto)
        {
            var mapped = this.mapper.Map<InventoryLog>(dto);
            mapped.CreatedAt = DateTime.UtcNow;
            await this.inventoryRepository.InsertAsync(mapped);
            await this.inventoryRepository.SaveAsync();

            return this.mapper.Map<InventoryLogForResultDto>(mapped);
        }

        public async Task<IEnumerable<InventoryLogForResultDto>> RetrieveAllByFiltering(Filter filter, PaginationParams @params = null)
        {
            var logsQuery = this.inventoryRepository.SelectAll(x => x.Type == filter.Type);

            if (filter.OwnerId != null)
                logsQuery = logsQuery.Where(x => x.OwnerId == filter.OwnerId);

            if (filter.ProductId != null)
                logsQuery = logsQuery.Where(x => x.ProductId == filter.ProductId);

            if (@params is null)
            {
                var logs = await logsQuery.ToListAsync();
                return this.mapper.Map<IEnumerable<InventoryLogForResultDto>>(logs);
            }

            var pagedLogs = await logsQuery.ToPagedList(@params).ToListAsync();
            return this.mapper.Map<IEnumerable<InventoryLogForResultDto>>(pagedLogs);
        }




        public async Task<InventoryLogForResultDto> RetrieveById(long id)
        {
            InventoryLog log = await this.inventoryRepository.SelectAsync(x => x.Id == id);
            if (log is null || log.IsDeleted == true)
                throw new FleetFlowException(404, "Log not found");
            return this.mapper.Map<InventoryLogForResultDto>(log);
        }
    }
}
