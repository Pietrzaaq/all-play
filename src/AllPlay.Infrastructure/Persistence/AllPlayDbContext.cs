using AllPlay.Domain.Entities.Map;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence;

public class AllPlayDbContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<Marker> Markers { get; set; }

    public AllPlayDbContext(DbContextOptions<AllPlayDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}