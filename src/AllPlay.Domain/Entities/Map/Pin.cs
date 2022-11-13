using System;
using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;

namespace AllPlay.Domain.Entities.Map;

public class Pin
{
    public List<Player> Players;
    
    public Guid PinId;
    public Coordinates? Coordinates;
    public SportType? SportType;
    public string? CreatedBy;
    public string? UpdatedBy;
    public DateTime CreateDate;
    public DateTime? UpdateDate;
}
