using AllPlay.Application.Common.Abstractions;
using AllPlay.Domain.Entities;

namespace AllPlay.Application.Queries;

public record GetAreaQuery(
        Guid Id) : IQuery<Area>;