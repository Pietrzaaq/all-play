using AllPlay.Domain.Exceptions;

namespace AllPlay.Application.Exceptions;

public sealed class SportEventWithSameIdAlreadyExistsException : AllPlayException
{
    Guid Id { get; }
    public SportEventWithSameIdAlreadyExistsException(Guid id) :
        base($"SportEvent with the id: {id} already exists")
    {
        Id = id;
    }
}