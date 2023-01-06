using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;

namespace AllPlay.Application.Queries.Handlers;

public class BrowseAreasQueryHandler : 
    IQueryHandler<BrowseAreasQuery, IReadOnlyList<AreaDto>>
{
    private readonly IAreaRepository _areaRepository;

    public BrowseAreasQueryHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task<IReadOnlyList<AreaDto>> HandleAsync(BrowseAreasQuery query)
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