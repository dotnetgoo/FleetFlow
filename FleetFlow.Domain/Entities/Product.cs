using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string Serial { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public ProductCategoryType? Category { get; set; }
    }
}
