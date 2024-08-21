using DotPharma.Catalog.Contracts;

namespace DotPharma.Pricing.Contracts;

public record Price(Sku ProductSku, decimal GrossValue, decimal NetValue, IReadOnlyCollection<Discount>? Discounts);
public record Discount(decimal Value, decimal Percent);

public record PriceRule(Sku ProductSku, PricingRuleType PricingRuleType, Price OriginalPrice, Price MinPrice, Price MaxPrice, DiscountRule DiscountRule);
public record DiscountRule(Sku ProductSku, PricingRuleType PricingRuleType, Discount OriginalDiscount, Discount MinDiscount, Discount MaxDiscount); 