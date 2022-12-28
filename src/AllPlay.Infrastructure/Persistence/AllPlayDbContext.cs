using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AllPlay.Infrastructure.Persistence;

public class AllPlayDbContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<Marker> Markers { get; set; }
    public DbSet<Player> Players { get; set; }

    public AllPlayDbContext(DbContextOptions<AllPlayDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}

public class AllPlayDbContextFactory : IDesignTimeDbContextFactory<AllPlayDbContext>
{
    public AllPlayDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AllPlayDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=AllPlay;Trusted_Connection=True; TrustServerCertificate=True");

        return new AllPlayDbContext(optionsBuilder.Options);
    }
}