using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Queries;

public record GetSportEventsQuery(
    Guid Id) : IQuery<SportEventDto>;
