using AllPlay.Domain.Exceptions;

namespace AllPlay.Application.Exceptions;

public sealed class SportEventWithTheSameDateAlreadyExistsException : AllPlayException
{
    Guid AreaId { get; }
    DateTime EventStartDate { get; }
    DateTime EventEndDate { get; }
    public SportEventWithTheSameDateAlreadyExistsException(Guid areaId, DateTime eventStartDate, DateTime eventEndDate) :
        base($"SportEvent with the area id: {areaId} between dates {eventStartDate} and {eventEndDate} already exists")
    {
        AreaId = areaId;
        EventStartDate = eventStartDate;
        EventEndDate = eventEndDate;
    }
}