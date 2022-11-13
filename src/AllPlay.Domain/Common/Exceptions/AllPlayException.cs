using System;

namespace AllPlay.Domain.Common.Exceptions;

public class AllPlayException : Exception
{
    protected AllPlayException(string message) : base(message)
    {
    }
}
