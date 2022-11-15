using Vehiculos_2019_0087.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_2019_0087.Data.Context;

public class MYDbContext : DbContext, IMYDbContext
{
    public MYDbContext(DbContextOptions options) : base(options)
    {
    
    }

     public virtual DbSet<Vehiculos> Vehiculos {get; set;}

    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}

public interface IMYDbContext
{
    
      public DbSet<Vehiculos> Vehiculos {get; set;}

      public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}