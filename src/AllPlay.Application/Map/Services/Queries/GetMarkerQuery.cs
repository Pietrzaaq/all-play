using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Map.Services.Queries;

public record GetMarkerQuery(
    Guid id) : IRequest<MarkerDto>;
