using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.DTO;
using AllPlay.Application.Exceptions;
using MediatR;

namespace AllPlay.Application.Map.Queries.Handlers;

public class GetSportEventQueryHandler : 
        IRequestHandler<GetSportEventQuery , SportEventDto>
{
    private readonly ISportEventRepository _sportEventRepository;

    public GetSportEventQueryHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }

    public async Task<SportEventDto> Handle(GetSportEventQuery query, CancellationToken cancellationToken)
    {
        var sportEvent = await _sportEventRepository.GetAsync(query.Id);
        
        if (sportEvent is null)
        {
            throw new SportEventNotFoundException(query.Id);
        }

        return sportEvent.AsDto();
    }
}