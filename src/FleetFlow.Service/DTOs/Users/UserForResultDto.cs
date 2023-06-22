using FleetFlow.Domain.Entities.Orders;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace FleetFlow.Service.DTOs.User;
public class UserForResultDto
{
    public long Id { get; set; }

    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("LastName")]
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    [JsonIgnore]
    public ICollection<Order> Orders { get; set; }
}
