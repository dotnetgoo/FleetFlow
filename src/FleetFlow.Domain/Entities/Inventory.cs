using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class Inventory : Auditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }

        public long LocationId { get; set; }
        public Location Location { get; set; }

        public long MerchantId { get; set; }
        public Merchant Merchant { get; set; }
    }
}
