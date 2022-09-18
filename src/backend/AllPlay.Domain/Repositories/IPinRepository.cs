using System.Collections.Generic;
using System.Threading.Tasks;

namespace AllPlay.Domain.Repositories;

public interface IPinRepository
{
    Task<Pin> GetAsync(int pinId);
    Task<bool> ExistsAsync(Coordinates coorditanes);
    Task<IReadOnlyList<Pin>> BrowseAsync();
}
