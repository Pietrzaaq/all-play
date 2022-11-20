using AllPlay.Domain.Entities.Map;

namespace AllPlay.Domain.Repositories;

public interface IMarkerRepository
{
    Task<Marker> GetAsync(Guid id);
    Task<bool> ExistsAsync(Coordinates coordinates);
    Task<bool> ExistsAsync(Guid id);

    Task AddAsync(Marker marker);
    Task<IReadOnlyList<Marker>> BrowseAsync();
}
