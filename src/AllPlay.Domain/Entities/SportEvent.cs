using AllPlay.Domain.ValueObjects;
using AllPlay.Domain.ValueObjects.Common;

namespace AllPlay.Domain.Entities;

public sealed class SportEvent
{
    private readonly List<Player> _players = new ();
    
    public Guid Id { get; }
    public Id AreaId { get; }
    public SportType SportType { get; }
    public string CreatedBy { get; }
    public DateTime CreationDate { get; }
    public DateTime EventStartDate { get; }
    public DateTime EventEndDate { get; }
    public IReadOnlyList<Player> Players => _players.AsReadOnly();

    private SportEvent()
    {
        
    }
    
    public SportEvent(
        Guid id,
        Guid areaId,
        SportType sportType,
        string createdBy,
        DateTime creationDate, 
        DateTime eventStartDate,
        DateTime eventEndDate)
    {
        Id = id;
        AreaId = areaId;
        SportType = sportType;
        CreatedBy = createdBy;
        CreationDate = creationDate;
        EventStartDate = eventStartDate;
        EventEndDate = eventEndDate;
    }

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }
}
