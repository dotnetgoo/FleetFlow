using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Domain.Enums
{
    public enum OrderStatus
    {
        Pending,
        Picking, 
        Packing,
        Shipping,
        Shipped,
        Cancelled
    }
}
