namespace AllPlay.Domain.Entities;

public class Player
{
    private Player()
    {
        
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}