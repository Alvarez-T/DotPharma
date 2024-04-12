using DotPharma.Abstract;

namespace DotPharma.Pricing.Contracts;

public record SetPriceCommand(Sku ProductSku, decimal Price, decimal Discount);
