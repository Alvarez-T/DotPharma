using DotPharma.Abstract;

namespace DotPharma.Pricing;

public record PriceDefined(Sku ProductSku, decimal Value, DateTime DefinedIn, Guid DefinedBy);
public record PriceIncreased(Sku Sku, decimal NewValue, DateTime DefinedIn, Guid DefinedBy);
public record PriceDecreased(Sku Sku, decimal NewValue, DateTime DefinedIn, Guid DefinedBy);
public record PriceNoChange(Sku ProductSku, decimal Value, DateTime DefinedIn, Guid DefinedBy);



public record DiscountApplied(Sku Sku);
public record DiscountRemoved(Sku Sku);
