using AllPlay.Application.Abstractions;
using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Map.Queries;

public record GetSportEventQuery(
    Guid Id) : IRequest<SportEventDto>;
