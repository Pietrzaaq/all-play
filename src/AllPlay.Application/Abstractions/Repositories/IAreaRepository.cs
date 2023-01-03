using AllPlay.Domain.Entities;

namespace AllPlay.Application.Abstractions.Repositories;

public interface IAreaRepository
{
    Task<Area> GetAsync(Guid id);
    
    Task<bool> ExistsAsync(Guid id);
}