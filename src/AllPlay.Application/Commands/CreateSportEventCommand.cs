using AllPlay.Application.Common.Abstractions;

namespace AllPlay.Application.Commands;

public record CreateSportEventCommand(
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreationDate,
    DateTime EventStartDate,
    DateTime EventEndDate 
    ) : ICommand;