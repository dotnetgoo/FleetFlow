using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Staffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities.StaffPermissions
{
    public class StaffPermission : Auditable
    {
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }

    }
}
