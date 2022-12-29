using AllPlay.Application.Abstractions;
using AllPlay.Application.DTO;
using AllPlay.Application.Exceptions;
using AllPlay.Application.Interfaces.Repositories;

namespace AllPlay.Application.Map.Queries.Handlers;

public class GetMarkerQueryHandler : 
        IQueryHandler<GetMarkerQuery , MarkerDto>
{
    private readonly IMarkerRepository _markerRepository;

    public GetMarkerQueryHandler(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }

    public async Task<MarkerDto> HandleAsync(GetMarkerQuery query)
    {
        var marker = await _markerRepository.GetAsync(query.Id);
        
        if (marker is null)
        {
            throw new MarkerNotFoundException(query.Id);
        }

        return marker.AsDto();
    }
}