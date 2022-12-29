using AllPlay.Application.Abstractions;

namespace AllPlay.Application.Map.Commands;

public record CreateMarkerCommand(
    Guid Id,
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreateDate,
    DateTime EventDate
    ) : ICommand;