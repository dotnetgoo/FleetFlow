using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class Cart : Auditable
    {
        public long UserId { get; set; }
        public ICollection<CartItem> Items { get; set; }
    }
}
