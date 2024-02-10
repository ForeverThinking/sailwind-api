using Microsoft.EntityFrameworkCore;

namespace SailwindApi.Core;

public class SailwindContext(DbContextOptions<SailwindContext> options) : DbContext(options)
{
    public DbSet<Location> Locations => Set<Location>();
}
