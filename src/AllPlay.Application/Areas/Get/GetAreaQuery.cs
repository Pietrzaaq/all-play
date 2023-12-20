using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Areas.Get;

public record GetAreaQuery(
        Guid Id) : IRequest<AreaDto>;