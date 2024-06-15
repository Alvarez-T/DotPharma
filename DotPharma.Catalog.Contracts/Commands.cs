namespace DotPharma.Catalog.Contracts;

public sealed record CreateProduct(Sku Sku, string Description, GroupId GroupId, SubGroupId? SubGroupId);

public sealed record UpdateProduct(Sku Sku, string Description, GroupId GroupId, SubGroupId SubGroupId);
public sealed record UpdateProductWithTracking(Product Product);
public sealed record DeleteProduct(Sku Sku);

public sealed record CreateSkuPattern();
public sealed record GenerateNextSkuFor();

public sealed record CreateProductGroup(GroupId Id, string Description, string SkuTag);
public sealed record UpdateProductGroup(GroupId Id, string Description, string SkuTag);

public sealed record DeleteProductGroup(GroupId Id);

public sealed record CreateProductSubGroup(string Description, string SkuTag, GroupId GroupOwnerId);
public sealed record UpdateProductSubGroup(SubGroupId Id, string Description, string SkuTag, GroupId GroupOwnerId);
public sealed record DeleteProductSubGroup(GroupId Id);