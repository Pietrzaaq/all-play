using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence.Repositories;

public class SportEventRepository : ISportEventRepository
{
    private readonly AllPlayDbContext _context;
    private readonly DbSet<SportEvent> _markers;

    public SportEventRepository(AllPlayDbContext context)
    {
        _context = context;
        _markers = context.Markers;
    }

    public async Task<SportEvent> GetAsync(Guid id) => 
        await _markers.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _markers.AnyAsync(x => x.AreaId == id);
    }

    public async Task<bool> ExistsAsync(Guid areaId, DateTime eventStartTime, DateTime eventEndTime)
    {
        return await _markers.AnyAsync(marker => 
            (marker.AreaId == areaId) &&
            (marker.EventStartDate >= eventStartTime) &&
            (marker.EventEndDate <= eventStartTime));
    }

    public async Task AddAsync(SportEvent sportEvent)
    {
        await _markers.AddAsync(sportEvent);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<SportEvent>> BrowseAsync()
    {
        return await _markers.ToListAsync();
    }
}