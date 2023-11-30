using AllPlay.Application.Common.Abstractions;
using MediatR;

namespace AllPlay.Application.Commands;

public record UpdateAreaCommand(
    Guid Id,
    string Name,
    string StreetAddress,
    string PhoneNumber,
    bool IsOutdoorArea,
    double Latitude,
    double Longitude
    ) : IRequest;