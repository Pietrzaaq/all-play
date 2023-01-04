using AllPlay.Domain.Exceptions;

namespace AllPlay.Application.Exceptions;

public class AreaWithSameCoordinatesAlreadyExistsException : AllPlayException
{
    public double Latitude { get; }
    public double Longitude { get; }
    public AreaWithSameCoordinatesAlreadyExistsException(
        double latitude, double longitude) :
        base($"Area with same latitude {latitude} and longitude {longitude} already exists")
    {
        Latitude = latitude;
        Longitude = longitude;
    }
}