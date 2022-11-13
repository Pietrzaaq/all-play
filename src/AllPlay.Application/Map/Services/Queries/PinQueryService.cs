using AllPlay.Application.DTO;
using AllPlay.Domain.Repositories;

namespace AllPlay.Application.Map.Services.Queries;

public class PinQueryService : IPinQueryService
{

    private readonly IPinRepository _pinRepository;

    public PinQueryService(IPinRepository pinRepository)
    {
        _pinRepository = pinRepository;
    }

    public async Task<PinDto> GetAsync(Guid id)
    {
        var pin = await _pinRepository.GetAsync(id);
        return pin.AsDto();
    }

    public async Task<IEnumerable<PinDto>> BrowseAsync()
    {
        var pins = await _pinRepository.BrowseAsync();
        return pins.Select(p => p.AsDto());
    }
}