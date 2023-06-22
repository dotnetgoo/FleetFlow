using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Configurations
{
    public class Filter
    {
        public long? ProductId { get; set; }
        public long? OwnerId { get; set; }
        public InventoryLogType Type { get; set; }
    }
}
