﻿using AllPlay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence;

public class AllPlayDbContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<SportEvent> Markers { get; set; }
    public DbSet<Player> Players { get; set; }

    public AllPlayDbContext(DbContextOptions<AllPlayDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("AllPlay");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}