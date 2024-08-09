using DotPharma.Catalog.Contracts;

namespace DotPharma.Pricing.Contracts;

public record PriceDefined(Sku ProductSku, decimal Value);
public record PriceIncreased(Sku Sku, decimal NewNetPrice, decimal NewGrossPrice);
public record PriceDecreased(Sku Sku, decimal NewNetPrice, decimal NewGrossPrice);
public record PriceChanged(Sku Sku, decimal NewNetPrice, decimal NewGrossPrice);
