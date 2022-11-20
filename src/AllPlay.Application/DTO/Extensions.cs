using AllPlay.Domain.Entities.Map;
using Mapster;

namespace AllPlay.Application.DTO;

public static class Extensions
{
    
    public static MarkerDto AsDto(this Marker marker)
    {
        return marker.Adapt<MarkerDto>();
    }
    
}