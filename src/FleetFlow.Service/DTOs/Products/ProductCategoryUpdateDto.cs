using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Products;

public class ProductCategoryUpdateDto
{
    [MinLength(3), MaxLength(200)]
    public string Name { get; set; }
}
