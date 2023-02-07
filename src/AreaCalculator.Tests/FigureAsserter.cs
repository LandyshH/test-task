using AreaCalculator.Interfaces;

namespace AreaCalculator.Tests;

public static class FigureAsserter
{
    public static void AssertArea(IFigure figure, double expected)
    {
        var area = figure.Area;
        Assert.Equal(expected, area, 6);
    }
}