using AllPlay.Application.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Map.Queries;

public record BrowseMarkerQuery :
    IQuery<IReadOnlyList<MarkerDto>>;
