namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryForResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AddressId { get; set; }
        public long? OwnerId { get; set; }
    }
}
