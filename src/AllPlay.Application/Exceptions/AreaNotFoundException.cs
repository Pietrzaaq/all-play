using AllPlay.Domain.Exceptions;

namespace AllPlay.Application.Exceptions;

public class AreaNotFoundException : AllPlayException
{
    Guid Id { get; }
    
    public AreaNotFoundException(Guid id) 
        : base($"Area with id: {id} not exists")
    {
        Id = id;
    }
}