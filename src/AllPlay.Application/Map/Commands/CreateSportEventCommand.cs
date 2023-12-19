using AllPlay.Application.Abstractions;
using MediatR;

namespace AllPlay.Application.Map.Commands;


public record CreateSportEventCommand(
    Guid Id,
    Guid AreaId,
    string SportType,
    string CreatedBy,
    DateTime EventStartDate,
    DateTime EventEndDate 
) : IRequest;