using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Users;

namespace FleetFlow.Domain.Entities.Staffs
{
    public class Staff : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}
