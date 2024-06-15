using DotPharma.Catalog.Contracts;

namespace DotPharma.Catalog.Handlers;

internal class SubGroupCommandHandler
{
    public static void Handle(CreateProductSubGroup request, CatalogDbContext catalogDbContext)
    {
        var subGroup = new ProductSubGroupEntity()
        {
            Description = request.Description,
            SkuTag = request.SkuTag,
            GroupOwnerId = request.GroupOwnerId
        };

        catalogDbContext.ProductSubGroup.Add(subGroup);
    }

    public static void Handle(UpdateProductSubGroup request, CatalogDbContext catalogDbContext)
    {
        ProductSubGroupEntity? subGroup = catalogDbContext.ProductSubGroup.Find(request.Id);

        if (subGroup is null)
            return;

        subGroup.Description = request.Description;
        subGroup.SkuTag = request.SkuTag;
        subGroup.GroupOwnerId = request.GroupOwnerId;
        
        catalogDbContext.ProductSubGroup.Update(subGroup);
    }

    public static void Handle(DeleteProductSubGroup request, CatalogDbContext catalogDbContext)
    {
        ProductSubGroupEntity? subGroup = catalogDbContext.ProductSubGroup.Find(request.Id);

        if (subGroup is null)
            return;

        catalogDbContext.ProductSubGroup.Remove(subGroup);
    }
}