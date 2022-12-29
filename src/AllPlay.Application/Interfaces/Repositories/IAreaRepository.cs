using AllPlay.Domain.Entities.Map;

namespace AllPlay.Application.Interfaces.Repositories;

public interface IAreaRepository
{
    Task<Area> GetAsync(Guid id);
    
    Task<bool> ExistsAsync(Guid id);
}