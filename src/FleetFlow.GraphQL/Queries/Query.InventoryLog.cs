using FleetFlow.Domain.Configurations;
using FleetFlow.Domain.Congirations;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.Interfaces.Warehouses;

namespace FleetFlow.GraphQL.Queries
{
    public partial class Query
    {
        public async ValueTask<InventoryLogForResultDto> GetInventoryLogByIdAsync([Service] IInventoryLogService service, long id)
        {
            return await service.RetrieveById(id);
        }
        public async ValueTask<IEnumerable<InventoryLogForResultDto>> GetInventoryAllAsync([Service] IInventoryLogService service,
            Filter filter, PaginationParams @params)
        {
            return await service.RetrieveAllByFiltering(filter, @params);
        }

    }
}
