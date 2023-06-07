using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Inventories
{
    public class InventoryForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Adress id is required")]
        public long AddressId { get; set; }

        [Required(ErrorMessage = "Region id is required")]
        public long RegionId { get; set; }

        [Required(ErrorMessage = "District id is required")]
        public long DistrictId { get; set; }
    }
}
