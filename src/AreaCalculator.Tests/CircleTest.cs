using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class CircleTest
{
    [Theory]
    [InlineData(-2)]
    public void ShouldThrowArgumentException_WhenRadiusIsNegative(double radius)
    {
        Assert.Throws<ArgumentException>(() =>
            new Circle(radius));
    }

    [Theory]
    [InlineData(4, Math.PI * 16)]
    [InlineData(0, 0)]
    public void Area_ShouldReturnCorrectResult(double radius, double expected)
    {
        var circle = new Circle(radius);
        FigureAsserter.AssertArea(circle, expected);
    }
}