using AllPlay.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.HasIndex(x => x.Id).IsUnique();
        
        builder.OwnsOne(x => x.Coordinates)
            .Property(x => x.Latitude).HasColumnName("Latitude");
        
        builder.OwnsOne(x => x.Coordinates)
            .Property(x => x.Longitude).HasColumnName("Longitude");
        // builder.OwnsOne(x => x.AvailableSportTypes);
        // builder.Property(e => e.AvailableSportTypes)
        //     .HasConversion(
        //         x => string.Join(";", x),
        //         x =>  x.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(x => new SportType(x)).ToList());

    }    
}