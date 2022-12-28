using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;

namespace AllPlay.Domain.Entities.Map;

public sealed class Marker
{
    private readonly List<Player> _players = new ();
    
    public Guid Id { get; }
    public Guid AreaId { get; }
    public SportType SportType { get; }
    public string CreatedBy { get; }
    public DateTime CreateDate { get; }
    public DateTime EventDate { get; }
    public Area Area { get; set; }
    public IReadOnlyList<Player> Players => _players.AsReadOnly();

    public Marker()
    {
        
    }
    
    private Marker(
        Guid id,
        Guid areaId,
        SportType sportType,
        string createdBy,
        DateTime createDate, DateTime eventDate)
    {
        Id = id;
        AreaId = areaId;
        SportType = sportType;
        CreatedBy = createdBy;
        CreateDate = createDate;
        EventDate = eventDate;
    }

    public static Marker Create(
        Guid id,
        Guid areaId,
        SportType sportType,
        string createdBy,
        DateTime createDate,
        DateTime eventDate
    )
    {
        return new(
            id,
            areaId,
            sportType,
            createdBy,
            createDate,
            eventDate
        );
    }
}
