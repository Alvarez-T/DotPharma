using DotPharma.Catalog.Contracts;

namespace DotPharma.Catalog;

internal class ProductSubGroupEntity
{
    public SubGroupId Id { get; set; }
    public required string Description { get; set; }
    public string? SkuTag { get; set; }
    public required GroupId GroupOwnerId { get; set; }
}