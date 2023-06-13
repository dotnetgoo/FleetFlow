using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.DTOs.Orders
{
    public class OrderResultDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public UserForResultDto User { get; set; }
        public long AddressId { get; set; }
        public AddressForResultDto Address { get; set; }
        public long RegionId { get; set; }
        public DistrictResultDto District { get; set; }
        public bool IsSaved { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItemForResultDto> OrderItems { get; set; }
        public ICollection<DiscountResultDto> Discounts { get; set; }
    }
}
