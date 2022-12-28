using AllPlay.Domain.Entities.Game.ValueObjects;

namespace AllPlay.Domain.Entities.Map;

public class Area
{
    private readonly List<SportType> _availableSportTypes = new();
    private readonly List<Marker> _markers = new();
    public Guid Id { get; }
    
    public Coordinates Coordinates { get; }

    // public IReadOnlyList<SportType> AvailableSportTypes => _availableSportTypes.AsReadOnly();

    public IReadOnlyList<Marker> Markers => _markers.AsReadOnly();

    public Area()
    {
        
    }
    
    public Area(Guid id, Coordinates coordinates)
    {
        Id = id;
        Coordinates = coordinates;
    }
}