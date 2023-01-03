using AllPlay.Domain.Entities;
using Mapster;

namespace AllPlay.Application.DTO;

public static class Extensions
{

    public static SportEventDto AsDto(this SportEvent sportEvent)
        => new()
        {
            Id = sportEvent.Id,
            SportType = sportEvent.SportType,
            CreatedBy = sportEvent.CreatedBy,
            CreationDate = sportEvent.CreationDate,
            EventStartDate = sportEvent.EventStartDate,
            EventEndDate = sportEvent.EventEndDate,
            Players = sportEvent.Players.ToList()
        };

}