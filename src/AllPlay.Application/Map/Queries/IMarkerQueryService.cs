using AllPlay.Application.DTO;

namespace AllPlay.Application.Map.Services.Queries;

public interface IMarkerQueryService
{
    public Task<MarkerDto> GetAsync(Guid id);

    public Task<IEnumerable<MarkerDto>> BrowseAsync();
}