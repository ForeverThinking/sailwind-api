using FluentAssertions;
using SailwindApi.Api;

namespace SailwindApi.Tests;

public class CurrencyControllerTests
{
    private readonly CurrencyController _underTest;

    public CurrencyControllerTests()
    {
        _underTest = new CurrencyController();
    }

    [Fact]
    public void Post_GoldToCrowns_ReturnsCorrectValue()
    {
        // Arrange
        var goldAmount = 100;
        var expectedValue = 8928.57;

        // Act
        var result = _underTest.GoldToCrowns(goldAmount);

        // Assert
        result.Should().Be(expectedValue);
    }

    [Fact]
    public void Post_GoldToLions_ReturnsCorrectValue()
    {
        // Arrange
        var goldAmount = 100;
        var expectedValue = 3610.11;

        // Act
        var result = _underTest.GoldToLions(goldAmount);

        // Assert
        result.Should().Be(expectedValue);
    }

    [Fact]
    public void Post_GoldToDragons_ReturnsCorrectValue()
    {
        // Arrange
        var goldAmount = 100;
        var expectedValue = 32258.06;

        // Act
        var result = _underTest.GoldToDragons(goldAmount);

        // Assert
        result.Should().Be(expectedValue);
    }

    [Fact]
    public void Post_CrownsToGold_ReturnsCorrectValue()
    {
        // Arrange
        var crownAmount = 1000;
        var expectedValue = 11.2;

        // Act
        var result = _underTest.CrownsToGold(crownAmount);

        // Assert
        result.Should().Be(expectedValue);
    }

    [Fact]
    public void Post_LionsToGold_ReturnsCorrectValue()
    {
        // Arrange
        var lionAmount = 1000;
        var expectedValue = 27.7;

        // Act
        var result = _underTest.LionsToGold(lionAmount);

        // Assert
        result.Should().Be(expectedValue);
    }

    [Fact]
    public void Post_DragonsToGold_ReturnsCorrectValue()
    {
        // Arrange
        var dragonAmount = 1000;
        var expectedValue = 3.1;

        // Act
        var result = _underTest.DragonsToGold(dragonAmount);

        // Assert
        result.Should().Be(expectedValue);
    }
}
