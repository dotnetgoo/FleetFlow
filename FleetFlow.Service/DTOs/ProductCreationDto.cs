using FleetFlow.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs
{
    public class ProductCreationDto
    {
        [Required(ErrorMessage = "Name required")]
        [StringLength(30 , MinimumLength = 2)]
        [DisplayName("Name")]
        public string Name { get; set; } =string.Empty;

        [Required(ErrorMessage = "Enter the product Serial code")]
        [StringLength(30, MinimumLength = 2)]
        [DisplayName("Serial")]
        public string Serial { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price required")]
        [DisplayName("Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Weight required")]
        [DisplayName("Weight")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "Category required")]
        [DisplayName("Category")]
        public ProductCategoryType? Category { get; set; }
    }
}
