using FleetFlow.Domain.Commons;

namespace FleetFlow.Service.DTOs.InventoryLogs
{
    public class InventoryLogForCreationDto : Auditable
    {
        public long ProductId { get; set; }
        public int Amount { get; set; }
    }
}
