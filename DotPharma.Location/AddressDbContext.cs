using Microsoft.EntityFrameworkCore;

namespace DotPharma.Location;

internal class AddressDbContext : DbContext
{
    public DbSet<Address> Address { get; set; }
}
