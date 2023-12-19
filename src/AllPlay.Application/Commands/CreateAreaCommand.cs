using MediatR;

namespace AllPlay.Application.Commands;

public record CreateAreaCommand(
    string Name,
    string StreetAddress,
    string PhoneNumber,
    bool IsOutdoorArea,
    double Latitude,
    double Longitude
    ) : IRequest;