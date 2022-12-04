using AllPlay.Application.DTO;

namespace AllPlay.Application.Map.Services.Commands;

public interface IMarkerCommandService
{
    public Task CreateAsync(MarkerDto marker);
}