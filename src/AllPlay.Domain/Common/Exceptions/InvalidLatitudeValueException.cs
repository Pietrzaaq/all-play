namespace AllPlay.Domain.Common.Exceptions;

public class InvalidLatitudeValueException : AllPlayException
{
    double Latitude { get; set; }
    public InvalidLatitudeValueException(double latitude)
        : base($"Latitude value: {latitude} is not between -90 and 90 degrees")
    {
        Latitude = latitude;
    }
}