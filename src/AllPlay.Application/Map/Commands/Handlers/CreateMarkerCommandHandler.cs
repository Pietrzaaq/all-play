using AllPlay.Application.Exceptions;
using AllPlay.Application.Interfaces.Repositories;
using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;
using MediatR;

namespace AllPlay.Application.Map.Commands.Handlers;

public class CreateMarkerCommandHandler
    : IRequestHandler<CreateMarkerCommand>
{
    private readonly IMarkerRepository _markerRepository;

    public CreateMarkerCommandHandler(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }
    
    public async Task<Unit> Handle(CreateMarkerCommand command, CancellationToken cancellationToken)
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
        return Unit.Value;
    }
}