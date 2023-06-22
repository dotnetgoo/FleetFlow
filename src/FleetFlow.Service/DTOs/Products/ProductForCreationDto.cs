using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Product
{
    public class ProductForCreationDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the product serial code")]
        [StringLength(30, MinimumLength = 2)]
        public string Serial { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public long CategoryId { get; set; }
    }
}
