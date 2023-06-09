﻿using FleetFlow.Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Domain.Entities.Products
{
    public class ProductCategory : Auditable
    {
        [MinLength(3), MaxLength(200)]
        public string Name { get; set; }
    }
}
