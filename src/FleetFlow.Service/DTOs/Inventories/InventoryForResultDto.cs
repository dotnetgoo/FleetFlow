﻿namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryForResultDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public long LocationId { get; set; }
    }
}
