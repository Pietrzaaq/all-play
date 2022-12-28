using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AllPlay.Infrastructure.Persistence.Configurations;

internal sealed class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasIndex(x => x.Id).IsUnique();
    }    
}