using AllPlay.Domain.ValueObjects.Common;
using NetTopologySuite.Geometries;

namespace AllPlay.Domain.Entities;

public class Area
{
    private readonly List<SportEvent> _sportEvents = new();
    
    public Id Id { get; }
    public string OpenStreetMapId { get; }
    public string? OpenStreetMapName { get; }
    public string Name { get; }
    public string StreetAddress { get; }
    public string CountryRegion { get; }
    public string CountryIso { get; }
    public string PostalCode { get; }
    public string FormattedAddress { get; }
    public Point Point { get; }
    public Polygon Polygon { get; }
    public AllPlay.Domain.ValueObjects.Coordinates Coordinates { get; }
    public bool? IsOutdoorArea { get; }
    public string? Leisure { get; }
    public string Sport { get; }
    public bool HasMultipleSports { get; }
    public string? Surface { get; }
    public bool? Lit { get; }
    public bool? Access { get; }
    public string? Barrier { get; }
    public PhoneNumber? PhoneNumber { get; }
    public IReadOnlyList<SportEvent> SportEvents => _sportEvents.AsReadOnly();

    public Area()
    {
        
    }
    
    public Area(
        Id id,
        string openStreetMapId,
        string openStreetMapName,
        string name,
        string streetAddress,
        string countryRegion,
        string countryIso,
        string postalCode,
        string formattedAddress,
        Point point,
        Polygon polygon,
        AllPlay.Domain.ValueObjects.Coordinates coordinates,
        bool isOutdoorArea,
        string leisure,
        string sport,
        bool hasMultipleSports,
        string surface,
        bool? lit,
        bool? access,
        string barrier,
        PhoneNumber? phoneNumber)
    {
        Id = id;
        OpenStreetMapId = openStreetMapId;
        OpenStreetMapName = openStreetMapName;
        Name = name;
        StreetAddress = streetAddress;
        CountryRegion = countryRegion;
        CountryIso = countryIso;
        PostalCode = postalCode;
        FormattedAddress = formattedAddress;
        IsOutdoorArea = isOutdoorArea;
        Point = point;
        Polygon = polygon;
        Coordinates = coordinates;
        Leisure = leisure;
        Sport = sport;
        HasMultipleSports = hasMultipleSports;
        Surface = surface;
        Lit = lit;
        Access = access;
        Barrier = barrier;
        PhoneNumber = phoneNumber;
    }

    public void AddSportEvent(SportEvent sportEvent)
    {
        _sportEvents.Add(sportEvent);
    }
}