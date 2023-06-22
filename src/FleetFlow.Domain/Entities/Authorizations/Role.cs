using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.Authorizations;

public class Role : Auditable
{
    public string Name { get; set; }
}
