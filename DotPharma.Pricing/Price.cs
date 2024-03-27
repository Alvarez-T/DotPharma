using DotPharma.Abstract;

namespace DotPharma.Pricing;

public class Price
{
    public Guid Id { get; set; }
    public Sku ProductSku { get; set; }
    public decimal GrossValue { get; set; }
    public decimal NetValue { get; set; }
    public DateTime ModifiedIn { get; set; }
    public required string ModifiedBy { get; set; }
    public Discount? Discount { get; set; }
}

public record Discount(Guid Id, decimal Value);
