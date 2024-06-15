using DotPharma.Catalog.Contracts;

namespace DotPharma.Catalog.Handlers;

internal static class GroupCommandHandler
{
    public static void Handle(CreateProductGroup request, CatalogDbContext catalogDbContext)
    {
        var group = new ProductGroupEntity()
        {
            Id = request.Id,
            Description = request.Description,
            SkuTag = request.SkuTag
        };

        catalogDbContext.ProductGroup.Add(group);
    }

    public static void Handle(UpdateProductGroup request, CatalogDbContext catalogDbContext)
    {
        ProductGroupEntity? group = catalogDbContext.ProductGroup.Find(request.Id);
        
        if (group is null)
            return;

        group.Description = request.Description;
        group.SkuTag = request.SkuTag;

        catalogDbContext.Update(group);
    }

    public static void Handle(DeleteProductGroup request, CatalogDbContext catalogDbContext)
    {
        ProductGroupEntity? group = catalogDbContext.ProductGroup.Find(request.Id);

        if (group is null)
            return;

        catalogDbContext.Remove(group);
    }
}