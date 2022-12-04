using AllPlay.Application.DTO;
using AllPlay.Application.Repositories;

namespace AllPlay.Application.Map.Services.Queries;

public class MarkerQueryService : IMarkerQueryService
{

    private readonly IMarkerRepository _MarkerRepository;

    public MarkerQueryService(IMarkerRepository MarkerRepository)
    {
        _MarkerRepository = MarkerRepository;
    }

    public async Task<MarkerDto> GetAsync(Guid id)
    {
        var Marker = await _MarkerRepository.GetAsync(id);
        return Marker.AsDto();
    }

    public async Task<IEnumerable<MarkerDto>> BrowseAsync()
    {
        var Markers = await _MarkerRepository.BrowseAsync();
        return Markers.Select(p => p.AsDto());
    }
}