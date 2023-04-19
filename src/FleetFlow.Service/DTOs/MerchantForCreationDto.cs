﻿using System.ComponentModel.DataAnnotations;

namespace FleetFlow.Service.DTOs;

public class MerchantForCreationDto
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public AddressForCreationDto Address { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [Phone]
    public string Phone { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }
    public string Website { get; set; }
}
