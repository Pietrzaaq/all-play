using MediatR;

namespace AllPlay.Application.Map.Commands;

public record CreateMarkerCommand(
    Guid Id,
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreateDate,
    DateTime EventDate
    ) : IRequest<Unit>;