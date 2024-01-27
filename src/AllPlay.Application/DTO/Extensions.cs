using AllPlay.Domain.Entities;
using NetTopologySuite.IO;
using Newtonsoft.Json;

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
    {
        string coordinates;
        string polygon;
        
        var serializer = GeoJsonSerializer.Create();
        using (var stringWriter = new StringWriter())
        using (var jsonWriter = new JsonTextWriter(stringWriter))
        {
           serializer.Serialize(jsonWriter, area.Coordinates);
           coordinates = stringWriter.ToString();
        }
        
        using (var stringWriter = new StringWriter())
        using (var jsonWriter = new JsonTextWriter(stringWriter))
        {
            serializer.Serialize(jsonWriter, area.Polygon);
            polygon = stringWriter.ToString();
        }

        return new()
        {
            Id = area.Id,
            Name = area.Name,
            StreetAddress = area.StreetAddress,
            CountryRegion = area.StreetAddress,
            CountryIso = area.CountryIso,
            PostalCode = area.PostalCode,
            FormattedAddress = area.FormattedAddress,
            PhoneNumber = area.PhoneNumber?.Value,
            IsOutdoorArea = area.IsOutdoorArea,
            Coordinates = coordinates,
            Polygon = polygon,
            SportEvents = area.SportEvents.ToList()
        };
    } 
}