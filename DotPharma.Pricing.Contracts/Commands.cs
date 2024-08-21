using DotPharma.Abstract;
using DotPharma.Catalog.Contracts;

namespace DotPharma.Pricing.Contracts;

public record SetPriceCommand(Sku ProductSku, decimal Price, decimal Discount);
