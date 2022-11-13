using System;
using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;

namespace AllPlay.Domain.Entities.Map;

public class Pin
{
    private readonly List<Player> _players = new ();
    
    public Guid PinId { get; }
    public Coordinates Coordinates { get; }
    public SportType SportType { get; }
    public string CreatedBy { get; }
    public string UpdatedBy { get; }
    public DateTime CreateDate { get; }
    public DateTime? UpdateDate { get; }
    public IReadOnlyList<Player> Players => _players.AsReadOnly();
    
    private Pin(
        Guid pinId,
        Coordinates coordinates,
        SportType sportType,
        string createdBy,
        DateTime createDate,
        string updatedBy = null,
        DateTime? updateDate = null)
    {
        PinId = pinId;
        Coordinates = coordinates;
        SportType = sportType;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
        CreateDate = createDate;
        UpdateDate = updateDate;
    }

    public static Pin Create(
        Guid pinId,
        Coordinates coordinates,
        SportType sportType,
        string createdBy,
        DateTime createDate
    )
    {
        return new(
            pinId,
            coordinates,
            sportType,
            createdBy,
            createDate
        );
    }
}
