namespace AllPlay.Domain.Exceptions;

public class InvalidEntityIdException : AllPlayException
{
    object Id { get; }
    public InvalidEntityIdException(object id) 
        : base($"Cannot set: {id} as entity identifier")
    {
        Id = id;
    }
}