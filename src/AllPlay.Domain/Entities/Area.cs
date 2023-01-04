using AllPlay.Domain.Common.ValueObjects;
using AllPlay.Domain.ValueObjects;

namespace AllPlay.Domain.Entities;

public class Area
{
    // private readonly List<SportType> _availableSportTypes = new();
    private readonly List<SportEvent> _markers = new();
    
    public Guid Id { get; }
    public string Name { get; }
    public string StreetAddress { get; }
    public PhoneNumber PhoneNumber { get; }
    public bool IsOutdoorArea { get; }
    
    public Coordinates Coordinates { get; }

    // public IReadOnlyList<SportType> AvailableSportTypes => _availableSportTypes.AsReadOnly();

    public IReadOnlyList<SportEvent> Markers => _markers.AsReadOnly();

    public Area()
    {
        
    }
    
    public Area(Guid id, string name, string streetAddress, PhoneNumber phoneNumber, bool isOutdoorArea, Coordinates coordinates)
    {
        Id = id;
        Name = name;
        StreetAddress = streetAddress;
        PhoneNumber = phoneNumber;
        IsOutdoorArea = isOutdoorArea;
        Coordinates = coordinates;
    }
}