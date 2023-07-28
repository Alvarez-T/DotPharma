using DotPharma.Customer.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DotPharma.Customer;

public class CustomerDbContext : DbContext
{
    public DbSet<CustomerModel> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerModel>()
            .Property(c => c.Name)
            .HasMaxLength(60)
            .IsRequired();

        modelBuilder.Entity<CustomerModel>()
            .Property(c => c.RG.Value)
            .HasColumnName("RG")
            .HasMaxLength(9);

        modelBuilder.Entity<CustomerModel>()
            .Property(c => c.CPF.Value)
            .HasColumnName("CPF")
            .HasMaxLength(11);
    }
}
