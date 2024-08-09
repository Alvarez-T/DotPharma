using DotPharma.User.Contracts;

namespace DotPharma.Pricing;

public class Price
{
    public Sku ProductSku { get; set; }
    public decimal GrossValue { get; set; } 
    public decimal NetValue { get; set; }
    public List<Discount> Discounts { get; set; }

}

public enum PricingRuleType
{
    ProductBased,
    CategoryBased,
    GroupBased,
    HealthInsuranceBased,
    DeliveryBased,
}

public class PricingRule
{
    public Guid Id { get; set; }
    public PricingRuleType RuleType { get; set; }
    public Guid ReferenceId { get; set; }
    public Price PriceCalculated { get; set; }
}

public class DiscountRule
{
    public Guid Id { get; set; }
    public PricingRuleType RuleType { get; set; }
    public Guid ReferenceId { get; set; }
    public Discount DiscountCalculated { get; set; }
}

public class Discount
{
    public Guid Id { get; set; }
    public decimal Value { get; set; }
    public decimal Percent { get; set; }
    public string? Description { get; set; }
    public required AuditInfo AuditInfo { get; set; }
    public required DiscountRule DiscountRule { get; set; }
}
