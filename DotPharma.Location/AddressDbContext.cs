using Microsoft.EntityFrameworkCore;

namespace DotPharma.Location;

internal class AddressDbContext : DbContext
{
    public DbSet<AddressEntity> Address { get; set; }
}
