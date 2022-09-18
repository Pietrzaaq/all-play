using System;
using AllPlay.Domain.Entities.Map.ValueObjects;

namespace AllPlay.Domain.Entities.Map;

public class Pin
{
    public int PinId;
    public Coordinates? Coordinates;
    public SportType? SportType;
    public string? CreatedBy;
    public string? UpdatedBy;
    public DateTime CreateDate;
    public DateTime? UpdateDate;

    

}
