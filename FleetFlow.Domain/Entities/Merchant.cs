using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class Merchant : Auditable
    {
        public string Name { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }
        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
    }
}
