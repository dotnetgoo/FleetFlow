using FleetFlow.Service.DTOs.Product;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.Products;

public class ProductCategoryResultDto
{
    public long Id { get; set; }

    [MinLength(3), MaxLength(200)]
    public string Name { get; set; }

    public ICollection<ProductForResultDto> Products { get; set; }
}
