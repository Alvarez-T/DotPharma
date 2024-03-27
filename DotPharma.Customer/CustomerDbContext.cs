using DotPharma.Customer.Contracts;
using JasperFx.Core;
using JasperFx.Core.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DotPharma.Customer;

internal sealed class CustomerDbContext : DbContext
{
    public DbSet<Contracts.Customer> Customers { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var customerConfiguration = modelBuilder.Entity<Contracts.Customer>();

        customerConfiguration
            .HasKey(c => c.CPF.Value);

        customerConfiguration
            .Property(c => c.CPF.Value)
            .HasColumnName("CPF")
            .HasMaxLength(11);

        customerConfiguration
            .Property(c => c.Name)
            .HasMaxLength(60)
            .IsRequired();

        customerConfiguration
            .Property(c => c.RG.Value)
            .HasColumnName("RG")
            .HasMaxLength(9);

        customerConfiguration
            .Property(c => c.CreationDate);
    }
}
