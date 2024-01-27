using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.DTO;
using MediatR;

namespace AllPlay.Application.Areas.Browse;

public class BrowseAreasQueryHandler : 
    IRequestHandler<BrowseAreasQuery, IReadOnlyList<AreaDto>>
{
    private readonly IAreaRepository _areaRepository;

    public BrowseAreasQueryHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task<IReadOnlyList<AreaDto>> Handle(BrowseAreasQuery query,  CancellationToken cancellationToken)
    {
        var areas = await _areaRepository.BrowseAsync();
        
        if (areas is null)
        {
            return null;
        }

        var areasDto = areas.Select(x => x.AsDto()).ToList();
        
        return areasDto;
    }
}