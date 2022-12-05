using MediatR;

namespace AllPlay.Application.Map.Services.Commands;

public record CreateMarkerCommand(
    Guid Id,
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreateDate,
    DateTime EventDate
    ) : IRequest;