using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.DTO;
using AllPlay.Application.Exceptions;

namespace AllPlay.Application.Queries.Handlers;

public class GetAreaQueryHandler
    : IQueryHandler<GetAreaQuery, AreaDto>
{
    private readonly IAreaRepository _areaRepository;

    public GetAreaQueryHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task<AreaDto> HandleAsync(GetAreaQuery query)
    {
        var area = await _areaRepository.GetAsync(query.Id);

        if (area is null)
        {
            throw new AreaNotFoundException(query.Id);
        }

        return area.AsDto();
    }
}