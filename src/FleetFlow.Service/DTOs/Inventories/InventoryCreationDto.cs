using FleetFlow.Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryCreationDto : Auditable
    {
        [Required(ErrorMessage = "Product id is required")]
        public long ProductId { get; set; }
        [Required(ErrorMessage = "Amount is requred")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "Location id is requred")]
        public long LocationId { get; set; }
    }
}
