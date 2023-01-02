using AllPlay.Domain.Entities.Map;
using Mapster;

namespace AllPlay.Application.DTO;

public static class Extensions
{

    public static MarkerDto AsDto(this Marker marker)
        => new()
        {
            Id = marker.Id,
            SportType = marker.SportType,
            CreatedBy = marker.CreatedBy,
            CreationDate = marker.CreationDate,
            EventStartDate = marker.EventStartDate,
            EventEndDate = marker.EventEndDate,
            Players = marker.Players.ToList()
        };

}