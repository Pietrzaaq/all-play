using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;
using AllPlay.Domain.ValueObjects.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

internal sealed class SportEventConfiguration : IEntityTypeConfiguration<SportEvent>
{
    public void Configure(EntityTypeBuilder<SportEvent> builder)
    {
        builder.HasMany(sportEvent => sportEvent.Players);

        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.AreaId).IsRequired();

        builder.Property(x => x.AreaId)
            .HasConversion(x => x.Value, x => new Id(x));
        
        builder.Property(x => x.SportType)
            .HasConversion(x => x.Sport, x => new SportType(x));

        builder.Property(x => x.CreationDate).IsRequired();

        builder.Property(x => x.CreatedBy).IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.EventStartDate);
        
        builder.Property(x => x.EventEndDate);
        
   }
}