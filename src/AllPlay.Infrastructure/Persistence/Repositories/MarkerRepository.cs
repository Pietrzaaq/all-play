using AllPlay.Application.Interfaces.Repositories;
using AllPlay.Domain.Entities.Map;
using Microsoft.EntityFrameworkCore;

namespace AllPlay.Infrastructure.Persistence.Repositories;

public class MarkerRepository : IMarkerRepository
{
    private readonly AllPlayDbContext _context;
    private readonly DbSet<Marker> _markers;

    public MarkerRepository(AllPlayDbContext context, DbSet<Marker> markers)
    {
        _context = context;
        _markers = markers;
    }

    public async Task<Marker?> GetAsync(Guid id) => 
        await _markers.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _markers.AnyAsync(x => x.AreaId == id);
    }

    public async Task AddAsync(Marker marker)
    {
        await _markers.AddAsync(marker);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<Marker>> BrowseAsync()
    {
        return await _markers.ToListAsync();
    }
}