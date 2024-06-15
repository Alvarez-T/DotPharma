namespace DotPharma.Catalog.Contracts;

public record ProductHeader(Sku Sku, string Description);
public record Product(Sku Sku, string Description, ProductGroup Group, ProductSubGroup? SubGroup);


public record ProductGroup(GroupId Id, string Description, string SkuTag);
public record ProductSubGroup(GroupId Id, string Description, string SkuTag, ProductGroup DerivedFrom);