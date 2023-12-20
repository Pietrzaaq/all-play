using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.SportEvents.Browse;

public record BrowseSportEventsQuery :
    IRequest<IReadOnlyList<SportEventDto>>;
