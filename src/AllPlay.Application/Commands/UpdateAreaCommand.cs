using AllPlay.Application.Common.Abstractions;

namespace AllPlay.Application.Commands;

public record UpdateAreaCommand(
    Guid Id,
    string Name,
    string StreetAddress,
    string PhoneNumber,
    bool IsOutdoorArea,
    double Latitude,
    double Longitude
    ) : ICommand;