using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;
using AllPlay.Application.Exceptions;

namespace AllPlay.Application.Queries.Handlers;

public class GetSportEventQueryHandler : 
        IQueryHandler<GetSportEventsQuery , SportEventDto>
{
    private readonly ISportEventRepository _sportEventRepository;

    public GetSportEventQueryHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }

    public async Task<SportEventDto> HandleAsync(GetSportEventsQuery query)
    {
        var sportEvent = await _sportEventRepository.GetAsync(query.Id);
        
        if (sportEvent is null)
        {
            throw new SportEventNotFoundException(query.Id);
        }

        return sportEvent.AsDto();
    }
}