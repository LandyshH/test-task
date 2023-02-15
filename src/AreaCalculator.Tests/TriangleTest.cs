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
        // Arrange
        
        // Act
        var act = () => new Triangle(firstSide, secondSide, thirdSide);
        
        // Assert 
        Assert.Throws<ArgumentException>(act);
    }

    [Theory]
    [InlineData(1, 1, 1, 0.4330127)]
    [InlineData(5, 2, 6, 4.6837484)]
    public void Area_ShouldReturnCorrectResult(double firstSide, 
        double secondSide, double thirdSide, double expected)
    {
        // Arrange
        
        // Act
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        // Assert
        FigureAsserter.AssertArea(triangle, expected);
    }
    
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 3, 5, false)]
    public void IsRightTriangle_ShouldReturnCorrectResult(double firstSide, 
        double secondSide, double thirdSide, bool expected)
    {
        // Arrange
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        // Act
        var actual = triangle.IsRectangular();
        
        // Assert
        Assert.Equal(expected, actual);
    }
}