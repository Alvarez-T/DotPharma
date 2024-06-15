
using DotPharma.Abstract;
using DotPharma.Catalog.Contracts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DotPharma.Catalog;

internal class ProductEntity
{
    public Guid UniqueKey { get; set; }
    public required Sku Sku { get; set; }
    public required string Description { get; set; }
    public required GroupId GroupId { get; set; } 
    public SubGroupId? SubGroup { get; set; }
}

internal class ProductGroupEntity
{
    public GroupId Id { get; set; }
    public required string Description { get; set; }
    public string? SkuTag { get; set; }
}

internal class ProductSubGroupEntity
{
    public SubGroupId Id { get; set; }
    public required string Description { get; set; }
    public string? SkuTag { get; set; }
    public required GroupId GroupOwnerId { get; set; }
}

