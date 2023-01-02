using System.Xml.Schema;
using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

internal sealed class MarkerConfiguration : IEntityTypeConfiguration<Marker>
{
    public void Configure(EntityTypeBuilder<Marker> builder)
    {
        builder.HasOne(marker => marker.Area)
            .WithMany(area => area.Markers)
            .HasForeignKey(marker => marker.AreaId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(marker => marker.Players)
            .WithOne()
            .HasForeignKey(x => x.Id);

        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.CreationDate).IsRequired();
        
        builder.Property(x => x.CreatedBy).IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.EventStartDate);
        
        builder.Property(x => x.EventEndDate);
        
        builder.Property(x => x.SportType)
            .HasConversion(x => x.Sport, x => new SportType(x));
    }
}