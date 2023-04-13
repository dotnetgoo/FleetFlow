using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities
{
    public class ProductCategory : Auditable
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
