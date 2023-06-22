using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.DTOs.InventoryLogs
{
    public class InventoryLogForCreationDto
    {
        public long ProductId { get; set; }
        public long InventoryId { get; set; }
        public int Amount { get; set; }
        public long OwnerId { get; set; }
        public string Description { get; set; }
        public InventoryLogType Type { get; set; }
    }
}
