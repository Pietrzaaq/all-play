using AllPlay.Application.Abstractions;
using AllPlay.Application.Exceptions;
using AllPlay.Application.Interfaces.Repositories;
using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.Map.Commands.Handlers;

public class CreateMarkerCommandHandler
    : ICommandHandler<CreateMarkerCommand>
{
    private readonly IMarkerRepository _markerRepository;
    
    public CreateMarkerCommandHandler(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }
    
    public async Task HandleAsync(CreateMarkerCommand command)
    {
        var existingMarker = 
            await _markerRepository.ExistsAsync(
                command.AreaId,
                command.EventStartDate,
                command.EventEndDate);
        
        if (existingMarker)
        {
            throw new MarkerWithTheSameDateAlreadyExistsException(
                command.AreaId,
                command.EventStartDate,
                command.EventEndDate);
        }

        var marker = Marker.Create(
            Guid.NewGuid(), 
            command.AreaId,
            new SportType(command.SportType),
            command.CreatedBy,
            command.CreationDate,
            command.EventStartDate,
            command.EventEndDate);

        await _markerRepository.AddAsync(marker);
    }
}