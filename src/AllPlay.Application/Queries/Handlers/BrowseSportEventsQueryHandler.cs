using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Queries.Handlers;

public class BrowseSportEventsQueryHandler :
    IQueryHandler<BrowseSportEventsQuery , IReadOnlyList<SportEventDto>>
{
    private readonly ISportEventRepository _sportEventRepository;

    public BrowseSportEventsQueryHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }

    public async Task<IReadOnlyList<SportEventDto>> HandleAsync(BrowseSportEventsQuery query)
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