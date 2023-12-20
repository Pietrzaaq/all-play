using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Areas.Browse;

public record BrowseAreasQuery :
    IRequest<IReadOnlyList<AreaDto>>;
