using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Domain.Entities;

namespace AllPlay.Application.Queries.Handlers;

public class GetAreaQueryHandler
    : IQueryHandler<GetAreaQuery, Area>
{
    private readonly IAreaRepository _areaRepository;

    public GetAreaQueryHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task<Area> HandleAsync(GetAreaQuery query)
    {
        return await _areaRepository.GetAsync(query.Id);
    }
}