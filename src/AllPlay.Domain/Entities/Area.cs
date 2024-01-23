using AllPlay.Domain.ValueObjects.Common;
using NetTopologySuite.Geometries;

namespace AllPlay.Domain.Entities;

public class Area
{
    private readonly List<SportEvent> _sportEvents = new();
    
    public Id Id { get; }
    public string Name { get; }
    public string StreetAddress { get; }
    public string CountryRegion { get; }
    public string CountryIso { get; }
    public string PostalCode { get; }
    public string FormattedAddress { get; }
    
    public PhoneNumber PhoneNumber { get; }
    public bool IsOutdoorArea { get; }
    
    public Point Coordinates { get; }
    public Polygon Polygon { get; }

    public IReadOnlyList<SportEvent> SportEvents => _sportEvents.AsReadOnly();

    private Area()
    {
        
    }
    
    public Area(
        Id id,
        string name,
        string streetAddress,
        string countryRegion,
        string countryIso,
        string postalCode,
        string formattedAddress,
        PhoneNumber phoneNumber,
        bool isOutdoorArea,
        Point coordinates,
        Polygon polygon)
    {
        Id = id;
        Name = name;
        StreetAddress = streetAddress;
        CountryRegion = countryRegion;
        CountryIso = countryIso;
        PostalCode = postalCode;
        FormattedAddress = formattedAddress;
        PhoneNumber = phoneNumber;
        IsOutdoorArea = isOutdoorArea;
        Coordinates = coordinates;
        Polygon = polygon;
    }

    public void AddSportEvent(SportEvent sportEvent)
    {
        _sportEvents.Add(sportEvent);
    }
}