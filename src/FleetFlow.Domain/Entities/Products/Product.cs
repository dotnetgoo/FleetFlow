using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Orders;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FleetFlow.Domain.Entities.Products
{
    public class Product : Auditable
    {
        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }
        public string Serial { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }

        public long CategoryId { get; set; }
        public ProductCategory Category { get; set; }

        [JsonIgnore]
        public ICollection<Discount> Discounts { get; set; }

        [JsonIgnore]
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
