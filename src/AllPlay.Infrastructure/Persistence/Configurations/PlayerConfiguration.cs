using AllPlay.Domain.Entities;
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