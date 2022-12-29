using AllPlay.Application.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Map.Queries;

public record GetMarkerQuery(
    Guid Id) : IQuery<MarkerDto>;
