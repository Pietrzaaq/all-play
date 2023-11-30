using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Exceptions;
using MediatR;

namespace AllPlay.Application.Commands.Handlers;

public class UpdateAreaCommandHandler
    : IRequestHandler<UpdateAreaCommand>
{
    private readonly IAreaRepository _areaRepository;

    public UpdateAreaCommandHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
        
    }

    public async Task Handle(UpdateAreaCommand command, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var area = await _areaRepository.GetAsync(command.Id);

        if (area is null)
        {
            throw new AreaNotFoundException(command.Id);
        }
    }
}