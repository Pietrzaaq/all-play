using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;

namespace AllPlay.Application.Abstractions.Repositories;

public interface IAreaRepository
{
    Task<Area> GetAsync(Guid id);

    Task<IReadOnlyList<Area>> BrowseAsync();
    Task<bool> ExistsAsync(Guid id);

    Task<bool> ExistsAsync(Coordinates coordinates);

    Task AddAsync(Area area);
}