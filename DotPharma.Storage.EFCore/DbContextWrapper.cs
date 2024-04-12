using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DotPharma.Storage.EFCore;

internal class DbContextWrapper : DbContext
{
    private readonly DbContext _dbContext;

    public DbContextWrapper(DbContext dbContext)
    {
        _dbContext = dbContext;


    }

    public DbContextWrapper(DbContext dbContext, DbContextOptions _) : base(_)
    {
        _dbContext = dbContext;
    }


   
}
