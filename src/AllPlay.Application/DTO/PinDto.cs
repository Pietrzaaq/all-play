using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.DTO;

public class PinDto
{
    public List<Player> Players;

    public Guid PinId;
    public Coordinates Coordinates;
    public string? CreatedBy;
    public string? UpdatedBy;
    public DateTime CreateDate;
    public DateTime? UpdateDate;
}