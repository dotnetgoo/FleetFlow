using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs.User;
public class UserForUpdateDto
{
    [Required(ErrorMessage = "FirstName is required")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "LastName is required")]
    public string LastName { get; set; }

    public string Phone { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter valid email")]
    public string Email { get; set; }

}
