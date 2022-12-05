using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

internal sealed class MarkerConfiguration : IEntityTypeConfiguration<Marker>
{
    public void Configure(EntityTypeBuilder<Marker> builder)
    {
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.AreaId).IsRequired();
        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.CreatedBy).IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.SportType)
            .HasConversion(x => x.Sport, x => new SportType(x));
    }
}