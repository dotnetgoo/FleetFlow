using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class InventoryLog : Auditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public long OwnerId { get; set; }
        public User User { get; set; }
        public string Description { get; set; }
        public InventoryLogType RemovedOrNot { get; set; }
    }
}
