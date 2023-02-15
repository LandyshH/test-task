using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class CircleTest
{
    [Fact]
    public void ShouldThrowArgumentException_WhenRadiusIsNegative()
    {
        // Arrange
        const int radius = -2;
        
        // Act
        var act = () => new Circle(radius);
        
        // Assert
        Assert.Throws<ArgumentException>(act);
    }

    [Theory]
    [InlineData(4, 50.26548245)]
    [InlineData(0, 0)]
    public void Area_ShouldReturnCorrectResult(double radius, double expected)
    {
        // Arrange
        
        // Act
        var circle = new Circle(radius);

        // Assert 
        FigureAsserter.AssertArea(circle, expected);
    }
}