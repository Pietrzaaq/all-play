using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.Interfaces.Repositories;

public interface IMarkerRepository
{
    Task<Marker> GetAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);

    Task AddAsync(Marker marker);
    Task<IReadOnlyList<Marker>> BrowseAsync();
}
