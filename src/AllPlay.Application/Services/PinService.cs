using AllPlay.Application.DTO;
using AllPlay.Domain.Repositories;
using System.Linq;
using AllPlay.Domain.Common.Exceptions;

namespace AllPlay.Application.Services;

public class PinService : IPinService
{

    private readonly IPinRepository _pinRepository;

    public PinService(IPinRepository pinRepository)
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

    public async Task CreateAsync(PinDto pinDto)
    {
        var alreadyExists = await _pinRepository.ExistsAsync(pinDto.PinId);
        if (alreadyExists)
        {
            throw new PinWithSameIdAlreadyExistsException(pinDto.PinId);
        }
        
        
    }
}