using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.Addresses
{
    public class Region : Auditable
    {
        public string NameUz { get; set; }
        public string NameRu { get; set; }
    }
}
