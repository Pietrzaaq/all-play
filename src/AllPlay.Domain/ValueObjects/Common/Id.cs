using AllPlay.Domain.Exceptions;

namespace AllPlay.Domain.ValueObjects.Common;

public sealed record Id
{
    public Guid Value { get; set; }

    public Id(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidEntityIdException(value);
        }

        Value = value;
    }

    public static implicit operator Guid(Id id) => id.Value;
    public static implicit operator Id(Guid value) => new(value);

    public static bool operator ==(Id a, Guid b)
        => a?.Value == b;    
    
    public static bool operator !=(Id a, Guid b)
        => a?.Value != b;
}