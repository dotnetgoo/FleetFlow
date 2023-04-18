using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Service.Commons.Attributes;

namespace FleetFlow.Service.DTOs
{
    public class UserForLoginDto
    {
        [EmailAddress, Required]
        public string Email { get; set; }

        [Required, MinLength(8)]
        public string Password { get; set; }
    }
}