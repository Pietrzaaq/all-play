using AllPlay.Domain.Common.Exceptions;

namespace AllPlay.Domain.Entities.Map;

public sealed record Coordinates
{
    public double Latitude { get; }
    public double Longitude { get; }

    public Coordinates(double latitude, double longitude)
    {
        if (latitude < -90 || latitude > 90)
        {
            throw new InvalidLatitudeValueException(latitude);
        }

        if (longitude < -180 || longitude > 180)
        {
            throw new InvalidLongitudeValueException(longitude);
        }

        Latitude = latitude;
        Longitude = longitude;
    }
}