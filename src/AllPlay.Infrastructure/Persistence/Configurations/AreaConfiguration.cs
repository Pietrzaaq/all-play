﻿using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.HasMany(area => area.SportEvents)
            .WithOne()
            .HasForeignKey(x => x.AreaId);
        
        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new Id(x));

        builder.Property(x => x.Name).IsRequired();

        builder.Property(x => x.StreetAddress).IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasConversion(x => x.Value, x => new PhoneNumber(x));
    }    
}