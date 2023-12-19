using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Map.Queries.Handlers;

public class BrowseSportEventQueryHandler :
    IRequestHandler<BrowseSportEventQuery , IReadOnlyList<SportEventDto>>
{
    private readonly ISportEventRepository _sportEventRepository;

    public BrowseSportEventQueryHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }

    public async Task<IReadOnlyList<SportEventDto>> Handle(BrowseSportEventQuery query, CancellationToken cancellationToken)
    {
        var sportEvents = await _sportEventRepository.BrowseAsync();

        var sportEventsDto = sportEvents.Select(x => x.AsDto()).ToList();

        return sportEventsDto;
    }
}