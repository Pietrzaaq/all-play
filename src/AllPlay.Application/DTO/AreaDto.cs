using AllPlay.Domain.Entities;

namespace AllPlay.Application.DTO;

public class AreaDto
{
    public List<SportEvent> SportEvents { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsOutdoorArea { get; set; }
    public double Latitude {get; set;} 
    public double Longitude {get; set;}
}