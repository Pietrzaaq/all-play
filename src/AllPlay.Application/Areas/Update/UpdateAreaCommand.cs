using MediatR;

namespace AllPlay.Application.Areas.Update;

public record UpdateAreaCommand(
    Guid Id,
    string Name,
    string StreetAddress,
    string PhoneNumber,
    bool IsOutdoorArea,
    double Latitude,
    double Longitude
    ) : IRequest;