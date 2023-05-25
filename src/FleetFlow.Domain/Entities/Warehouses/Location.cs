using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Location : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
<<<<<<< Updated upstream:src/FleetFlow.Domain/Entities/Warehouses/Location.cs
        public LocationType Type { get; set; }
=======
>>>>>>> Stashed changes:src/FleetFlow.Domain/Entities/Location.cs
    }
}
