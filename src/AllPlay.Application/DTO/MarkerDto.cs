using AllPlay.Domain.Entities.Game;
using AllPlay.Domain.Entities.Game.ValueObjects;
using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.DTO;

public class MarkerDto
{

    public MarkerDto()
    {
        
    }
    
    public List<Player> Players { get; set; }

    public Guid Id { get; set; }
    public SportType SportType { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime EventDate { get; set; }
}