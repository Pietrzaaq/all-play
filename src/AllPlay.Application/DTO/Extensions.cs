using AllPlay.Domain.Entities.Map;
using Mapster;

namespace AllPlay.Application.DTO;

public static class Extensions
{
    
    public static PinDto AsDto(this Pin pin)
    {
        return pin.Adapt<PinDto>();
    }
    
}