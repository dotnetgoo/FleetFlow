using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
using FleetFlow.Service.DTOs.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.DTOs.Orders
{
    public class OrderForCreationDto
    {
        public AddressForCreationDto AddressDto { get; set; }
    }
}
