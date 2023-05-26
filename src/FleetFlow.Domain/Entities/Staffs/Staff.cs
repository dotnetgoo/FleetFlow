using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities.Staffs
{
    public class Staff : Auditable
    {
        public long RoleId { get; set; }
        public Role Role { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}
