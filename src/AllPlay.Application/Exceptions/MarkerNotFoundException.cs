using AllPlay.Domain.Common.Exceptions;

namespace AllPlay.Application.Exceptions;

public class MarkerNotFoundException : AllPlayException
{
    Guid Id { get; }
    
    public MarkerNotFoundException(Guid id) 
        : base($"Marker with id: {id} not exists")
    {
        Id = id;
    }
}