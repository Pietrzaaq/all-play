using AllPlay.Application.DTO;
using AllPlay.Application.Repositories;
using AllPlay.Domain.Common.Exceptions;
using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.Map.Services.Commands;

public class MarkerCommandService : IMarkerCommandService
{
    private readonly IMarkerRepository _markerRepository;

    public MarkerCommandService(IMarkerRepository markerRepository)
    {
        _markerRepository = markerRepository;
    }
    
    public async Task CreateAsync(MarkerDto markerDto)
    {
        var alreadyExists = await _markerRepository.ExistsAsync(markerDto.Id);
        if (alreadyExists)
        {
            throw new MarkerWithSameIdAlreadyExistsException(markerDto.Id);
        }

        var marker = Marker.Create(
            markerDto.Id,
            markerDto.SportType,
            markerDto.CreatedBy,
            markerDto.CreateDate,
            markerDto.EventDate);

        await _markerRepository.AddAsync(marker);
    }
}