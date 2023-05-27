using FleetFlow.Domain.Enums;

namespace FleetFlow.Service.DTOs.InventoryLogs
{
    public class InventoryLogForResultDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public long OwnerId { get; set; }
        public string Description { get; set; }
        public InventoryLogType Type { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
