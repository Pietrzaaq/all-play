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
        var existingMarker = await _markerRepository.ExistsAsync(command.Id);
        
        if (existingMarker)
        {
            throw new MarkerWithSameIdAlreadyExistsException(command.Id);
        }

        var marker = Marker.Create(
            command.Id,
            command.AreaId,
            new SportType(command.SportType),
            command.CreatedBy,
            command.CreateDate,
            command.EventDate);

        await _markerRepository.AddAsync(marker);
    }
}