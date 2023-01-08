using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.Name).IsRequired();

        builder.Property(x => x.StreetAddress).IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasConversion(x => x.Value, x => new PhoneNumber(x));

        builder.OwnsOne(x => x.Coordinates)
            .Property(x => x.Latitude).HasColumnName("Latitude");
        
        builder.OwnsOne(x => x.Coordinates)
            .Property(x => x.Longitude).HasColumnName("Longitude");
    }    
}