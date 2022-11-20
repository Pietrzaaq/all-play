namespace AllPlay.Domain.Common.Exceptions;

public sealed class MarkerWithSameIdAlreadyExistsException : AllPlayException
{
    Guid Id { get; }
    public MarkerWithSameIdAlreadyExistsException(Guid id) :
        base($"Marker with the id: {id} already exists")
    {
        Id = id;
    }
}