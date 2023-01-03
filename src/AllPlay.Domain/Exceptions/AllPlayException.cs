namespace AllPlay.Domain.Exceptions;

public class AllPlayException : Exception
{
    protected AllPlayException(string message) : base(message)
    {
    }
}
