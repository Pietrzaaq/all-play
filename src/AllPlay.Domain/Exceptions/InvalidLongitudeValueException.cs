namespace AllPlay.Domain.Exceptions;

public class InvalidLongitudeValueException : AllPlayException
{
    double Longitude { get; }
    public InvalidLongitudeValueException(double longitude)
        : base ($"Latitude value: {longitude} is not between -90 and 90 degrees")
    {
        Longitude = longitude;
    }
}