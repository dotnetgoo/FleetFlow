using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs;

public class MerchantForCreationDto
{
    [Required(ErrorMessage = "Name is requaried")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Address is requaried")]
    public AddressForCreationDto Address { get; set; }

    [Required(ErrorMessage = "Phone is requaried")]
    [Phone]
    public string Phone { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email is requaried")]
    public string Email { get; set; }
    public string Website { get; set; }
}
