using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Domain.Entities
{
    public class User : Auditable
    {
        [MinLength(3), MaxLength(50)]
        public string FirstName { get; set; }
        [MinLength(3), MaxLength(50)]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.User;

        public ICollection<Order> Orders { get; set; }
    }
}
