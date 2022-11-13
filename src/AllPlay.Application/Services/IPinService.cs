using AllPlay.Application.DTO;
using AllPlay.Domain.Entities.Map;
using AllPlay.Domain.Repositories;

namespace AllPlay.Application.Services;

public interface IPinService
{
    public Task<PinDto> GetAsync(Guid id);

    public Task<IEnumerable<PinDto>> BrowseAsync();
    public Task CreateAsync(PinDto pin);
}