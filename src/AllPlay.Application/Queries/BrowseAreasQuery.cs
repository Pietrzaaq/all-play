using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Queries;

public record BrowseAreasQuery :
    IQuery<IReadOnlyList<AreaDto>>;
