using Microsoft.AspNetCore.Mvc;
using SailwindApi.Core;

namespace SailwindApi.Api;

[ApiController]
[Route("[controller]/[action]")]
public class VoyageController(IVoyageService voyageServices) : ControllerBase
{
    private readonly IVoyageService _voyageService = voyageServices;

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetLocations()
    {
        var locations = await _voyageService.GetLocationsAsync();

        return Ok(locations);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> AddLocation(Location location)
    {
        await _voyageService.AddLocationAsync(location);

        return NoContent();
    }
}
