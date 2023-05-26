using FleetFlow.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities.Authorizations;

public class Permission : Auditable
{
    public string Name { get; set; }

    public ICollection<Permission> Permissions { get; set;}
}
