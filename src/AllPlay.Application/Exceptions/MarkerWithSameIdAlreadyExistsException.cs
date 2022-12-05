using AllPlay.Domain.Common.Exceptions;

namespace AllPlay.Application.Exceptions;

public sealed class MarkerWithSameIdAlreadyExistsException : AllPlayException
{
    Guid Id { get; }
    public MarkerWithSameIdAlreadyExistsException(Guid id) :
        base($"Marker with the id: {id} already exists")
    {
        Id = id;
    }
}