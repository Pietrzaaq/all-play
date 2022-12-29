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
            .HasForeignKey(x => x.Id)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(marker => marker.Players)
            .WithOne()
            .HasForeignKey(x => x.Id);

        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.CreateDate).IsRequired();
        
        builder.Property(x => x.CreatedBy).IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.EventDate);
        
        builder.Property(x => x.SportType)
            .HasConversion(x => x.Sport, x => new SportType(x));
    }
}