using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

internal sealed class SportEventConfiguration : IEntityTypeConfiguration<SportEvent>
{
    public void Configure(EntityTypeBuilder<SportEvent> builder)
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