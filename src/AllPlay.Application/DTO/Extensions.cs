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
            CreateDate = marker.CreateDate,
            EventDate = marker.EventDate,
            Players = marker.Players.ToList()
        };

}