using FleetFlow.Domain.Entities;

namespace FleetFlow.Service.DTOs;

public class MerchantForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public AddressForResultDto Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }

    public ICollection<Inventory> Inventories { get; set; }
}