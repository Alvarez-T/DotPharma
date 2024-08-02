using DotPharma.Catalog.Contracts;

namespace DotPharma.Catalog;

internal class ProductEntity
{
    public Guid UniqueKey { get; set; }
    public required Sku Sku { get; set; }
    public required string Description { get; set; }
    public required GroupId GroupId { get; set; } 
    public SubGroupId? SubGroup { get; set; }
}