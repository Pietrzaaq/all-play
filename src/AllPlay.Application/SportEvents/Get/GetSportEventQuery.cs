using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.SportEvents.Get;

public record GetSportEventsQuery(
    Guid Id) : IRequest<SportEventDto>;
