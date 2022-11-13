using AllPlay.Application.DTO;

namespace AllPlay.Application.Map.Services.Queries;

public interface IPinQueryService
{
    public Task<PinDto> GetAsync(Guid id);

    public Task<IEnumerable<PinDto>> BrowseAsync();
}