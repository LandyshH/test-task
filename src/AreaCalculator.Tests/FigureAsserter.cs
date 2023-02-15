using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public static class FigureAsserter
{
    public static void AssertArea(Figure figure, double expected)
    {
        var area = figure.Area;
        Assert.Equal(expected, area, 6);
    }
}