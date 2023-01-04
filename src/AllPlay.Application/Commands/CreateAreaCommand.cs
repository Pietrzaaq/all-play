using AllPlay.Application.Common.Abstractions;
using AllPlay.Domain.Common.ValueObjects;

namespace AllPlay.Application.Commands;

public record CreateAreaCommand(
    string Name,
    string StreetAddress,
    string PhoneNumber,
    bool IsOutdoorArea,
    double Latitude,
    double Longitude
    ) : ICommand;