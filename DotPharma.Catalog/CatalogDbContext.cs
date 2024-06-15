using Microsoft.EntityFrameworkCore;

namespace DotPharma.Catalog;

internal sealed class CatalogDbContext : DbContext
{
   public DbSet<ProductEntity> Products { get; set; }
   public DbSet<ProductGroupEntity> ProductGroup { get; set; }
   public DbSet<ProductSubGroupEntity> ProductSubGroup { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<ProductEntity>()
         .Property(p => p.Description)
         .IsRequired()
         .HasMaxLength(60);
      
      modelBuilder.Entity<ProductEntity>()
         .Property(p => p.Sku)
         .IsRequired()
         .HasMaxLength(16);

      modelBuilder.Entity<ProductEntity>()
         .Property(p => p.GroupId)
         .IsRequired();

      modelBuilder.Entity<ProductGroupEntity>()
         .Property(group => group.Description)
         .IsRequired()
         .HasMaxLength(30);

      modelBuilder.Entity<ProductGroupEntity>()
         .Property(group => group.SkuTag)
         .HasMaxLength(4);

      modelBuilder.Entity<ProductSubGroupEntity>()
         .Property(subGroup => subGroup.Description)
         .IsRequired()
         .HasMaxLength(30);

      modelBuilder.Entity<ProductSubGroupEntity>()
         .Property(subGroup => subGroup.SkuTag)
         .HasMaxLength(4);

      modelBuilder.Entity<ProductSubGroupEntity>()
         .Property(subGroup => subGroup.GroupOwnerId)
         .IsRequired();
   }
}
