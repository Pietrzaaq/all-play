using AllPlay.Application.Common.Abstractions;

namespace AllPlay.Application.Commands;

public record CreateAreaCommand(
    Guid Id,
    string Name,
    string StreetAddress,
    string PhoneNumber,
    bool IsOutdoorArea,
    double Latitude,
    double Longitude
    ) : ICommand;