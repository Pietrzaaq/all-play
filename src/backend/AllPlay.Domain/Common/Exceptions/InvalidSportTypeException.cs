namespace AllPlay.Domain.Common.Exceptions;
public sealed class InvalidSportTypeException : AllPlayException
{
    public InvalidSportTypeException() : 
        base("Defined sport type is invalid")
    {
    }
}
