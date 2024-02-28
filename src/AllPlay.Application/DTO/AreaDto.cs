using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects.Common;
using NetTopologySuite.Geometries;

namespace AllPlay.Application.DTO;

public class AreaDto
{
    public List<SportEvent> SportEvents { get; set; }
    public Guid Id { get; set; }
    public string OpenStreetMapId { get; set; }
    public string? OpenStreetMapName { get; set; }
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string CountryRegion { get; set; }
    public string CountryIso { get; set; }
    public string PostalCode { get; set; }
    public string FormattedAddress { get; set; }
    public string Point { get; set; }
    public string Polygon { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public bool? IsOutdoorArea { get; set; }
    public string? Leisure { get; set; }
    public string Sport { get; set; }
    public bool HasMultipleSports { get; set; }
    public string? Surface { get; set; }
    public bool? Lit { get; set; }
    public bool? Access { get; set; }
    public string? Barrier { get; set; }
    public string? PhoneNumber { get; set; }
}