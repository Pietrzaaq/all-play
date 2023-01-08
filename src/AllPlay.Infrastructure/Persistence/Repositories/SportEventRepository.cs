using AllPlay.Application.Abstractions.Repositories;
using AllPlay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence.Repositories;

public class SportEventRepository : ISportEventRepository
{
    private readonly AllPlayDbContext _context;
    private readonly DbSet<SportEvent> _sportEvents;

    public SportEventRepository(AllPlayDbContext context)
    {
        _context = context;
        _sportEvents = context.SportEvents;
    }

    public async Task<SportEvent> GetAsync(Guid id) => 
        await _sportEvents.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _sportEvents.AnyAsync(x => x.AreaId == id);
    }

    public async Task<bool> ExistsAsync(Guid areaId, DateTime eventStartTime, DateTime eventEndTime)
    {
        return await _sportEvents.AnyAsync(marker => 
            marker.AreaId == areaId &&
            marker.EventStartDate >= eventStartTime &&
            marker.EventEndDate <= eventStartTime);
    }

    public async Task AddAsync(SportEvent sportEvent)
    {
        await _sportEvents.AddAsync(sportEvent);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<SportEvent>> BrowseAsync()
    {
        return await _sportEvents
            .Include(x => x.Players)
            .ToListAsync();
    }
}