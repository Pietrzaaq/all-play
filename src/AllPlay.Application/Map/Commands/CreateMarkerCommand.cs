using AllPlay.Application.Abstractions;

namespace AllPlay.Application.Map.Commands;

public record CreateMarkerCommand(
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreationDate,
    DateTime EventStartDate,
    DateTime EventEndDate 
    ) : ICommand;