using DotPharma.Catalog.Contracts;

namespace DotPharma.Catalog;

internal class ProductGroupEntity
{
    public GroupId Id { get; set; }
    public required string Description { get; set; }
    public string? SkuTag { get; set; }
}