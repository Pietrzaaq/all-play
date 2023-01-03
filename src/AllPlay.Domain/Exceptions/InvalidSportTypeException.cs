namespace AllPlay.Domain.Exceptions;
public sealed class InvalidSportTypeException : AllPlayException
{
    public InvalidSportTypeException() : 
        base("Defined sport type is invalid")
    {
    }
}
