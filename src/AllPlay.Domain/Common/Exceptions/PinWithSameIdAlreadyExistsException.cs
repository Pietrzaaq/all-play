namespace AllPlay.Domain.Common.Exceptions;

public sealed class PinWithSameIdAlreadyExistsException : AllPlayException
{
    public PinWithSameIdAlreadyExistsException(Guid id) :
        base($"Pin with the id: {id} already exists")
    {
    }
}