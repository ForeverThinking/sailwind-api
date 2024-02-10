using Microsoft.EntityFrameworkCore;
using SailwindApi.Core;

namespace SailwindApi.Api;

public class VoyageService(SailwindContext context) : IVoyageService
{
    private readonly SailwindContext _context = context;

    public async Task<List<Location>> GetLocationsAsync()
    {
        return await _context.Locations.ToListAsync();
    }

    public async Task AddLocationAsync(Location location)
    {
        await _context.Locations.AddAsync(location);
        await _context.SaveChangesAsync();        
    }
}
