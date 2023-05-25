using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.DTOs.Orders
{
    public class OrderItemForResultDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public ProductForResultDto Product { get; set; }
        public int Amount { get; set; }
    }
}