using SailwindApi.Core;

namespace SailwindApi.Api;

public interface IVoyageService
{
    public Task<List<Location>> GetLocationsAsync();
    public Task AddLocationAsync(Location location);
}
