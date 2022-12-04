using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;

namespace AllPlay.Domain.Entities.Map;

public sealed class Marker
{
    private readonly List<Player> _players = new ();
    
    public Guid Id { get; }
    public SportType SportType { get; }
    public string CreatedBy { get; }
    public DateTime CreateDate { get; }
    public DateTime EventDate { get; }
    public IReadOnlyList<Player> Players => _players.AsReadOnly();
    
    private Marker(
        Guid id,
        SportType sportType,
        string createdBy,
        DateTime createDate, DateTime eventDate)
    {
        Id = id;
        SportType = sportType;
        CreatedBy = createdBy;
        CreateDate = createDate;
        EventDate = eventDate;
    }

    public static Marker Create(
        Guid id,
        SportType sportType,
        string createdBy,
        DateTime createDate,
        DateTime eventDate
    )
    {
        return new(
            id,
            sportType,
            createdBy,
            createDate,
            eventDate
        );
    }
}
