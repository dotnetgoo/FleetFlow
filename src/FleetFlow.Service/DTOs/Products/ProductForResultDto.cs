using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Warehouses;
using System.Text.Json.Serialization;

namespace FleetFlow.Service.DTOs.Product;

public class ProductForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Serial { get; set; }
    public decimal Price { get; set; }
    public decimal Weight { get; set; }
    public long CategoryId { get; set; }
    public ProductCategory Category { get; set; }

    [JsonIgnore]
    public ICollection<Inventory> Inventories { get; set; }

    [JsonIgnore]
    public ICollection<OrderItem> OrderItems { get; set; }
}
