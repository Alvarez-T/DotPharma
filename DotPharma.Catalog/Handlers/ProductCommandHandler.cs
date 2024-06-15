using DotPharma.Catalog.Contracts;

namespace DotPharma.Catalog.Handlers;

internal static class ProductCommandHandler
{
    public static void Handle(CreateProduct request, CatalogDbContext catalogDbContext)
    {
        var productEntity = new ProductEntity()
        {
            Sku = request.Sku,
            Description = request.Description,
            GroupId = request.GroupId,
            SubGroup = request.SubGroupId
        };

        catalogDbContext.Products.Add(productEntity);
    }

    public static void Handle(UpdateProduct request, CatalogDbContext catalogDbContext)
    {
        ProductEntity? productEntity = catalogDbContext.Products.Find(request.Sku);

        if (productEntity is null)
            return;

        productEntity.Description = request.Description;
        productEntity.GroupId = request.GroupId;
        productEntity.SubGroup = request.SubGroupId;

        catalogDbContext.Update(productEntity);
    }

    public static void Handle(UpdateProductWithTracking productWithTracking)
    {

    }

    public static void Handle(DeleteProduct request, CatalogDbContext catalogDbContext)
    {
        ProductEntity? productEntity = catalogDbContext.Products.Find(request.Sku);

        if (productEntity is null)
            return;

        catalogDbContext.Remove(productEntity);
    }

    public static void Handle(GenerateNextSkuFor request)
    {

    }

    public static void Handle(CreateSkuPattern request)
    {
        
    }

}