using AllPlay.Application.DTO;
using AllPlay.Domain.Repositories;
using MediatR;

namespace AllPlay.Application.Map.Services.Queries.Handlers;

public class BrowseMarkerQueryHandler :
    IRequestHandler<BrowseMarkerQueryHandler , MarkerDto>
{
    private readonly IMarkerRepository _markerRepository;

    public BrowseMarkerQueryHandler(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }

    public async Task<MarkerDto> Handle()
    {
        Task.CompletedTask;

        return null;
    }
}