using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using System.ComponentModel;

namespace FleetFlow.Service.DTOs;
public class UserForResultDto
{
    public long Id { get; set; }    

    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("LastName")]
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; } = UserRole.User;
    public ICollection<Order> Orders { get; set; }
}
