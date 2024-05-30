using AllPlay.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence;

public class AllPlayDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<SportEvent> SportEvents { get; set; }
    public DbSet<Player> Players { get; set; }

    public AllPlayDbContext(DbContextOptions<AllPlayDbContext> options) 
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("AllPlay");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
