using MediatR;

namespace AllPlay.Application.SportEvents.Create;

public record CreateSportEventCommand(
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreationDate,
    DateTime EventStartDate,
    DateTime EventEndDate 
    ) : IRequest;