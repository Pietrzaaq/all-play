using AllPlay.Domain.Common.Exceptions;

namespace AllPlay.Application.Exceptions;

public sealed class MarkerWithTheSameDateAlreadyExistsException : AllPlayException
{
    Guid AreaId { get; }
    DateTime EventStartDate { get; }
    DateTime EventEndDate { get; }
    public MarkerWithTheSameDateAlreadyExistsException(Guid areaId, DateTime eventStartDate, DateTime eventEndDate) :
        base($"Marker with the area id: {areaId} between dates {eventStartDate} and {eventEndDate} already exists")
    {
        AreaId = areaId;
        EventStartDate = eventStartDate;
        EventEndDate = eventEndDate;
    }
}