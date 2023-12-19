using AllPlay.Application.Exceptions;
using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;
using MediatR;

namespace AllPlay.Application.Map.Commands.Handlers;

public class CreateSportEventCommandHandler
    : IRequestHandler<CreateSportEventCommand>
{
    private readonly ISportEventRepository _sportEventRepository;
    private readonly IDateTimeProvider _dateTimeProvider;

    public CreateSportEventCommandHandler(ISportEventRepository sportEventRepository, IDateTimeProvider dateTimeProvider)
    {
        _sportEventRepository = sportEventRepository;
        _dateTimeProvider = dateTimeProvider;
    }
    
    public async Task Handle(CreateSportEventCommand command, CancellationToken cancellationToken)
    {
        var existingSportEvent = await _sportEventRepository.ExistsAsync(command.Id);
        
        if (existingSportEvent)
        {
            throw new SportEventWithSameIdAlreadyExistsException(command.Id);
        }

        var sportEvent = new SportEvent(
            command.Id,
            command.AreaId,
            new SportType(command.SportType),
            command.CreatedBy,
            _dateTimeProvider.UtcNow,
            command.EventStartDate,
            command.EventStartDate);

        await _sportEventRepository.AddAsync(sportEvent);
    }
}