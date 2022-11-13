using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.DTO;

public class PinDto
{
    public List<Player> Players { get; set; }

    public Guid PinId { get; set; }
    public Coordinates Coordinates { get; set;}
    public SportType SportType { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}