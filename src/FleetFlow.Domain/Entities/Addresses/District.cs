using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.Addresses
{
    public class District : Auditable
    {
        public long RegionId { get; set; }
        public string NameUz { get; set; }
        public string NameRu { get; set; }
    }
}
