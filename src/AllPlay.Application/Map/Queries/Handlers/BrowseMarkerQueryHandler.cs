using AllPlay.Application.Abstractions;
using AllPlay.Application.DTO;
using AllPlay.Application.Interfaces.Repositories;

namespace AllPlay.Application.Map.Queries.Handlers;

public class BrowseMarkerQueryHandler :
    IQueryHandler<BrowseMarkerQuery , IReadOnlyList<MarkerDto>>
{
    private readonly IMarkerRepository _markerRepository;

    public BrowseMarkerQueryHandler(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }

    public async Task<IReadOnlyList<MarkerDto>> HandleAsync(BrowseMarkerQuery query)
    {
        var markers = await _markerRepository.BrowseAsync();

        if (markers is not null)
        {
            throw new ArgumentNullException();
        }

        var markersDto = markers.Select(x => x.AsDto()).ToList();

        return markersDto;
    }
}