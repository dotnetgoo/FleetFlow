using FleetFlow.Service.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Interfaces
{
    public interface IOrderService
    {
        ValueTask<OrderResultDto> AddAsync();
    }
}
