using AllPlay.Domain.ValueObjects;
using AllPlay.Domain.ValueObjects.Common;

namespace AllPlay.Domain.Entities;

public class Area
{
    // private readonly List<SportType> _availableSportTypes = new();
    private readonly List<SportEvent> _sportEvents = new();
    
    public Id Id { get; }
    public string Name { get; }
    public string StreetAddress { get; }
    public PhoneNumber PhoneNumber { get; }
    public bool IsOutdoorArea { get; }
    
    public Coordinates Coordinates { get; }

    // public IReadOnlyList<SportType> AvailableSportTypes => _availableSportTypes.AsReadOnly();

    public IReadOnlyList<SportEvent> SportEvents => _sportEvents.AsReadOnly();

    private Area()
    {
        
    }
    
    public Area(Id id, string name, string streetAddress, PhoneNumber phoneNumber, bool isOutdoorArea, Coordinates coordinates)
    {
        Id = id;
        Name = name;
        StreetAddress = streetAddress;
        PhoneNumber = phoneNumber;
        IsOutdoorArea = isOutdoorArea;
        Coordinates = coordinates;
    }

    public void AddSportEvent(SportEvent sportEvent)
    {
        _sportEvents.Add(sportEvent);
    }
}