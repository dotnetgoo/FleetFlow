using FleetFlow.Domain.Commons;

namespace FleetFlow.Domain.Entities.Addresses
{
    public class Address : Auditable
    {
        public string Street { get; set; }
        public string Department { get; set; }
        public string Home { get; set; }
        public string DomofonCode { get; set; }
        public string Floor { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
