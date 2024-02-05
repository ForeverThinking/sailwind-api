using Microsoft.AspNetCore.Mvc;

namespace SailwindApi.Api;

[ApiController]
[Route("[controller]/[action]")]
public class CurrencyController : ControllerBase
{
    private readonly double _goldToCrownConversion = 0.0112;
    private readonly double _goldToLionConversion = 0.0277;
    private readonly double _goldToDragonConversion = 0.0031;

    [HttpPost]
    public double GoldToCrowns(double gold)
        => Math.Round(gold / _goldToCrownConversion, 2);

    [HttpPost]
    public double GoldToLions(double gold)
        => Math.Round(gold / _goldToLionConversion, 2);

    [HttpPost]
    public double GoldToDragons(double gold)
        => Math.Round(gold / _goldToDragonConversion, 2);

    [HttpPost]
    public double CrownsToGold(double crowns)
        => Math.Round(crowns * _goldToCrownConversion, 2);

    [HttpPost]
    public double LionsToGold(double lions)
        => Math.Round(lions * _goldToLionConversion, 2);

    [HttpPost]
    public double DragonsToGold(double dragons)
        => Math.Round(dragons * _goldToDragonConversion, 2);
}
