using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Domain.Entities.Warehouses
{
    public class Location : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
