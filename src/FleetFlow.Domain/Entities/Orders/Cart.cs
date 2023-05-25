using FleetFlow.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Entities
{
    public class Cart : Auditable
    {
        public long UserId { get; set; }
        public ICollection<CartItem> Items { get; set; }
    }
}
