using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Inventories
{
    public class ProductInventoryCreationDto
    {
        [Required(ErrorMessage = "Product id is required")]
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Location id is required")]
        public long LocationId { get; set; }

        [Required(ErrorMessage = "Inventory id is required")]
        public long InventoryId { get; set; }

    }
}
