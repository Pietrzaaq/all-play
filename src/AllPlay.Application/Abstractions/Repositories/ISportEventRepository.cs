using AllPlay.Domain.Entities;

namespace AllPlay.Application.Abstractions.Repositories;

public interface ISportEventRepository
{
    Task<SportEvent> GetAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
    Task<bool> ExistsAsync(Guid areaId, DateTime eventStartTime, DateTime eventEndTime);

    Task AddAsync(SportEvent sportEvent);
    Task<IReadOnlyList<SportEvent>> BrowseAsync();
}
