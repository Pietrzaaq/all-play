using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.Repositories;

public interface IMarkerRepository
{
    Task<Marker> GetAsync(Guid id);
    Task<bool> ExistsAsync(Coordinates coordinates);
    Task<bool> ExistsAsync(Guid id);

    Task AddAsync(Marker marker);
    Task<IReadOnlyList<Marker>> BrowseAsync();
}
