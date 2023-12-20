using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Exceptions;
using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;
using MediatR;

namespace AllPlay.Application.SportEvents.Create;

public class CreateSportEventCommandHandler
    : IRequestHandler<CreateSportEventCommand>
{
    private readonly ISportEventRepository _sportEventRepository;
    
    public CreateSportEventCommandHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }
    
    public async Task Handle(CreateSportEventCommand command, CancellationToken cancellationToken)
    {
        var existingSportEvent = 
            await _sportEventRepository.ExistsAsync(
                command.AreaId,
                command.EventStartDate,
                command.EventEndDate);
        
        if (existingSportEvent)
        {
            throw new SportEventWithTheSameDateAlreadyExistsException(
                command.AreaId,
                command.EventStartDate,
                command.EventEndDate);
        }

        var sportEvent =  new SportEvent(
            Guid.NewGuid(),  
            command.AreaId,
            new SportType(command.SportType),
            command.CreatedBy,
            command.CreationDate,
            command.EventStartDate,
            command.EventEndDate);

        await _sportEventRepository.AddAsync(sportEvent);
    }
}