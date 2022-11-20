using AllPlay.Application.DTO;
using AllPlay.Application.Exceptions;
using AllPlay.Domain.Entities.Map;
using AllPlay.Domain.Repositories;
using MediatR;

namespace AllPlay.Application.Map.Services.Queries.Handlers;

public class GetMarkerQueryHandler : 
        IRequestHandler<GetMarkerQuery , MarkerDto>
{
    private readonly IMarkerRepository _markerRepository;

    public GetMarkerQueryHandler(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }

    public async Task<MarkerDto> Handle(GetMarkerQuery query, CancellationToken cancellationToken)
    {
        var marker = await _markerRepository.GetAsync(query.id);
        
        if (marker is not null)
        {
            throw new MarkerNotFoundException(query.id);
        }

        return marker.AsDto();
    }
}