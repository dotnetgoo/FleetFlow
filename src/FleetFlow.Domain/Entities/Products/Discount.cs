using FleetFlow.Domain.Commons;
using FleetFlow.Domain.Enums;

namespace FleetFlow.Domain.Entities.Products;

public class Discount : Auditable
{
    public long ProductId { get; set; }
    public Product Product { get; set; }
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime? FinishedAt { get; set; }
    public decimal Amount { get; set; }
    public DiscountState State { get; set; } = DiscountState.Active;

    /// <summary>
    /// Calculate discount price of product
    /// </summary>
    private decimal? priceInDiscount;
    public decimal PriceInDiscount
    {
        get
        {
            if (priceInDiscount == null)
            {
                priceInDiscount = CalculateDiscountPrice(Product);
            }
            return priceInDiscount.Value;
        }
        set
        {
            priceInDiscount = value;
        }
    }
    private decimal CalculateDiscountPrice(Product product) => product.Price - ((product.Price / 100) * Amount);
}
