using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Queries;

public record BrowseSportEventsQuery :
    IQuery<IReadOnlyList<SportEventDto>>;
