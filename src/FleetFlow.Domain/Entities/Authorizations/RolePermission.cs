using FleetFlow.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities.Authorizations;

public class RolePermission : Auditable
{
    public long RoleId { get; set; }
    public Role Role { get; set; }

    public long PermissonId { get; set; }
    public Permission Permisson { get; set; }
}
