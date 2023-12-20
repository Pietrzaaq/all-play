using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Exceptions;
using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;
using AllPlay.Domain.ValueObjects.Common;
using MediatR;

namespace AllPlay.Application.Areas.Create;

public class CreateAreaCommandHandler
    : IRequestHandler<CreateAreaCommand>
{
    private readonly IAreaRepository _areaRepository;

    public CreateAreaCommandHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task Handle(CreateAreaCommand command, CancellationToken cancellationToken)
    {
        var coordinates = new Coordinates(command.Latitude, command.Longitude);

        var existingArea =
            await _areaRepository.ExistsAsync(coordinates);

        if (existingArea)
        {
            throw new AreaWithSameCoordinatesAlreadyExistsException(coordinates.Latitude,
                coordinates.Longitude);
        }

        var phoneNumber = command.IsOutdoorArea.Equals(true) || string.IsNullOrEmpty(command.PhoneNumber)
            ? null
            : new PhoneNumber(command.PhoneNumber);

        var area = new Area(
            Guid.NewGuid(),
            command.Name,
            command.StreetAddress,
            phoneNumber,
            command.IsOutdoorArea,
            coordinates);

        await _areaRepository.AddAsync(area);
    }
}