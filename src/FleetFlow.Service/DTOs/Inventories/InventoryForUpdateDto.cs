using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryForUpdateDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Address id is required")]
        public long AddressId { get; set; }
    }
}
