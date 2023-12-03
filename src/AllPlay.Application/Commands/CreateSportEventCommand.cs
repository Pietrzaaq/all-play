using AllPlay.Application.Common.Abstractions;
using MediatR;

namespace AllPlay.Application.Commands;

public record CreateSportEventCommand(
    Guid Id,
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime CreationDate,
    DateTime EventStartDate,
    DateTime EventEndDate 
    ) : IRequest;