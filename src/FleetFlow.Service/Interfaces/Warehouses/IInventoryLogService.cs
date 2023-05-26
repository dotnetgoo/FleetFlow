using FleetFlow.Domain.Configurations;
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
        Task<InventoryLogForResultDto> RetrieveById(long id);
        Task<IEnumerable<InventoryLogForResultDto>> RetrieveAllByFiltering(Filter filter, PaginationParams @params = null);
    }
}
