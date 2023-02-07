using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(4, 2, 2)]
    [InlineData(-4, 2, 8)]
    public void ShouldThrowArgumentException_WhenTriangleNotExists(double firstSide, 
        double secondSide, double thirdSide)
    {
        Assert.Throws<ArgumentException>(() =>
            new Triangle(firstSide, secondSide, thirdSide));
    }

    [Theory]
    [InlineData(1, 1, 1, 0.4330127)]
    [InlineData(5, 2, 6, 4.6837484)]
    public void Area_ShouldReturnCorrectResult(double firstSide, 
        double secondSide, double thirdSide, double expected)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        FigureAsserter.AssertArea(triangle, expected);
    }
    
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 3, 5, false)]
    public void IsRightTriangle_ShouldReturnCorrectResult(double firstSide, 
        double secondSide, double thirdSide, bool expected)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        var actual = triangle.IsRightTriangle();
        Assert.Equal(expected, actual);
    }
}