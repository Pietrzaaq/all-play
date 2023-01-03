using AllPlay.Domain.ValueObjects;

namespace AllPlay.Domain.Entities;

public class Area
{
    private readonly List<SportType> _availableSportTypes = new();
    private readonly List<SportEvent> _markers = new();
    public Guid Id { get; }
    
    public Coordinates Coordinates { get; }

    // public IReadOnlyList<SportType> AvailableSportTypes => _availableSportTypes.AsReadOnly();

    public IReadOnlyList<SportEvent> Markers => _markers.AsReadOnly();

    public Area()
    {
        
    }
    
    public Area(Guid id, Coordinates coordinates)
    {
        Id = id;
        Coordinates = coordinates;
    }
}