using System.Collections.Generic;
using System.Threading.Tasks;
using AllPlay.Domain.Entities.Map;

namespace AllPlay.Domain.Repositories;

public interface IPinRepository
{
    Task<Pin> GetAsync(Guid id);
    Task<bool> ExistsAsync(Coordinates coordinates);
    Task<bool> ExistsAsync(Guid id);
    Task<IReadOnlyList<Pin>> BrowseAsync();
}
