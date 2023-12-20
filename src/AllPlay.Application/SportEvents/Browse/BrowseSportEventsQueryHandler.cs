using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.SportEvents.Browse;

public class BrowseSportEventsQueryHandler :
    IRequestHandler<BrowseSportEventsQuery , IReadOnlyList<SportEventDto>>
{
    private readonly ISportEventRepository _sportEventRepository;

    public BrowseSportEventsQueryHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }

    public async Task<IReadOnlyList<SportEventDto>> Handle(BrowseSportEventsQuery query, CancellationToken cancellationToken)
    {
        var sportEvents = await _sportEventRepository.BrowseAsync();

        if (sportEvents is null)
        {
            return null;
        }

        var sportEventsDto = sportEvents.Select(x => x.AsDto()).ToList();

        return sportEventsDto;
    }
}