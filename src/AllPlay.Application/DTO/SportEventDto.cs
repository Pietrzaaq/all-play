using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;

namespace AllPlay.Application.DTO;

public class SportEventDto
{

    public SportEventDto()
    {
        
    }
    
    public List<Player> Players { get; set; }

    public Guid Id { get; set; }
    public string SportType { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime EventStartDate { get; set; }
    public DateTime EventEndDate { get; set; }
}