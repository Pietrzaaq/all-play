using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Map.Queries;

public record BrowseMarkerQuery :
    IRequest<IReadOnlyList<MarkerDto>>;
