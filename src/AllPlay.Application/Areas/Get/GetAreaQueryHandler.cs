using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.DTO;
using AllPlay.Application.Exceptions;
using MediatR;

namespace AllPlay.Application.Areas.Get;

public class GetAreaQueryHandler
    : IRequestHandler<GetAreaQuery, AreaDto>
{
    private readonly IAreaRepository _areaRepository;

    public GetAreaQueryHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task<AreaDto> Handle(GetAreaQuery query, CancellationToken cancellationToken)
    {
        var area = await _areaRepository.GetAsync(query.Id);

        if (area is null)
        {
            throw new AreaNotFoundException(query.Id);
        }

        return area.AsDto();
    }
}