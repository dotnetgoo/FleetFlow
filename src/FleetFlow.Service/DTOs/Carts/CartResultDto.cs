namespace FleetFlow.Service.DTOs.Carts;

public class CartResultDto
{
    public long Id { get; set; }
    public IEnumerable<CartItemUpdateDto> Items { get; set; }
}
