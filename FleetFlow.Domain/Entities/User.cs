using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities
{
    public class User : Auditable
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
    }
}
