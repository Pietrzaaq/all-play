using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.Exceptions;
using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;

namespace AllPlay.Application.Commands.Handlers;

public class CreateSportEventCommandHandler
    : ICommandHandler<CreateSportEventCommand>
{
    private readonly ISportEventRepository _sportEventRepository;
    
    public CreateSportEventCommandHandler(ISportEventRepository sportEventRepository)
    {
        _sportEventRepository = sportEventRepository;
    }
    
    public async Task HandleAsync(CreateSportEventCommand command)
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

        var newSportEventId = Guid.NewGuid();

        var sportEvent = SportEvent.Create(
            newSportEventId, 
            command.AreaId,
            new SportType(command.SportType),
            command.CreatedBy,
            command.CreationDate,
            command.EventStartDate,
            command.EventEndDate);

        await _sportEventRepository.AddAsync(sportEvent);
    }
}