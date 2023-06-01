using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Product;

namespace FleetFlow.Service.DTOs.Orders
{
    public class OrderItemForResultDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public ProductForResultDto Product { get; set; }
        public long ProductInventoryAssignmentId { get; set; }
        public ProductInventory productInventoryAssignment { get; set; }
        public int Amount { get; set; }
    }
}