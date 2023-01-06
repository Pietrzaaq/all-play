using AllPlay.Domain.Entities;
using Mapster;

namespace AllPlay.Application.DTO;

public static class Extensions
{

    public static SportEventDto AsDto(this SportEvent sportEvent)
        => new()
        {
            Id = sportEvent.Id,
            SportType = sportEvent.SportType.Sport,
            CreatedBy = sportEvent.CreatedBy,
            CreationDate = sportEvent.CreationDate,
            EventStartDate = sportEvent.EventStartDate,
            EventEndDate = sportEvent.EventEndDate,
            Players = sportEvent.Players.ToList()
        };

    public static AreaDto AsDto(this Area area)
        => new()
        {
            Id = area.Id,
            Name = area.Name,
            StreetAddress = area.StreetAddress,
            PhoneNumber = area.PhoneNumber.Value,
            IsOutdoorArea = area.IsOutdoorArea,
            Latitude = area.Coordinates.Latitude,
            Longitude = area.Coordinates.Longitude
        };

}