using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.Exceptions;
using AllPlay.Domain.Common.ValueObjects;
using AllPlay.Domain.Entities;
using AllPlay.Domain.ValueObjects;

namespace AllPlay.Application.Commands.Handlers;

public class CreateAreaCommandHandler
    : ICommandHandler<CreateAreaCommand>
{
    private readonly IAreaRepository _areaRepository;

    public CreateAreaCommandHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
    }

    public async Task HandleAsync(CreateAreaCommand command)
    {
        var coordinates = new Coordinates(command.Latitude, command.Longitude);

        var existingArea =
            await _areaRepository.ExistsAsync(coordinates);

        if (existingArea)
        {
            throw new AreaWithSameCoordinatesAlreadyExistsException(coordinates.Latitude,
                coordinates.Longitude);
        }

        var newAreaId = Guid.NewGuid();
        var phoneNumber = command.IsOutdoorArea.Equals(true) || string.IsNullOrEmpty(command.PhoneNumber) ? null : new PhoneNumber(command.PhoneNumber);

        var area = new Area(
            newAreaId,
            command.Name,
            command.StreetAddress,
            phoneNumber,
            command.IsOutdoorArea,
            coordinates);

        await _areaRepository.AddAsync(area);
    }
}