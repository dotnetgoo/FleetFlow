using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.InventoryLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces.Warehouses
{
    public interface IInventoryLogService
    {
        Task<InventoryLogForResultDto> AddAsync(InventoryLogForCreationDto dto);
        Task<InventoryLogForResultDto> RetrieveById(long id);
        Task<IEnumerable<InventoryLogForResultDto>> RetrieveAllByProductId(Filter filter, PaginationParams @params = null);
    }
}
