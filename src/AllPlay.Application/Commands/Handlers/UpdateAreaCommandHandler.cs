using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Application.Common.Abstractions;
using AllPlay.Application.Exceptions;

namespace AllPlay.Application.Commands.Handlers;

public class UpdateAreaCommandHandler
    : ICommandHandler<UpdateAreaCommand>
{
    private readonly IAreaRepository _areaRepository;

    public UpdateAreaCommandHandler(IAreaRepository areaRepository)
    {
        _areaRepository = areaRepository;
        
    }

    public async Task HandleAsync(UpdateAreaCommand command)
    {
        await Task.CompletedTask;

        var area = await _areaRepository.GetAsync(command.Id);

        if (area is null)
        {
            throw new AreaNotFoundException(command.Id);
        }
        
    }
}