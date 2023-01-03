using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence.Repositories;

public class AreaRepository : IAreaRepository
{
    private readonly AllPlayDbContext _context;
    private readonly DbSet<Area> _areas;

    public AreaRepository(AllPlayDbContext context)
    {
        _context = context;
        _areas = context.Areas;
    }

    public async Task<Area> GetAsync(Guid id) =>
        await _areas.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<bool> ExistsAsync(Guid id) =>
        await _areas.AnyAsync(x => x.Id == id);
}