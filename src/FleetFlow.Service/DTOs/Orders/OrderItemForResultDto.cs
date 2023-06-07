using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.DTOs.Orders
{
    public class OrderItemForResultDto
    {
        public long Id { get; set; }
        public int Amount { get; set; }
        public decimal AmountTotal { get; set; }
        public long ProductId { get; set; }
        public ProductForResultDto Product { get; set; }
        public long ProductInventoryId { get; set; }
        public ProductInventory ProductInventory { get; set; }
    }
}