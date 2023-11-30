using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Queries;

public record GetAreaQuery(
        Guid Id) : IRequest<AreaDto>;