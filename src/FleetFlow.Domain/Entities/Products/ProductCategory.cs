using FleetFlow.Domain.Commons;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FleetFlow.Domain.Entities.Products
{
    public class ProductCategory : Auditable
    {
        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Product> Products { get; set; }
    }
}
