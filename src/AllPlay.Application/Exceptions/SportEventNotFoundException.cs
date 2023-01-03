using AllPlay.Domain.Exceptions;

namespace AllPlay.Application.Exceptions;

public class SportEventNotFoundException : AllPlayException
{
    Guid Id { get; }
    
    public SportEventNotFoundException(Guid id) 
        : base($"SportEvent with id: {id} not exists")
    {
        Id = id;
    }
}