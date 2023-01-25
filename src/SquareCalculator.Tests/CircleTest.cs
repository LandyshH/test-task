namespace SquareCalculatorTests;

public class CircleTest
{
    [Theory]
    [InlineData(-2)]
    public void CalculateSquare_ShouldThrowArgumentException_WhenRadiusIsNegative(double radius)
    {
        Assert.Throws<ArgumentException>(() =>
            new Circle(radius).Square);
    }

    [Theory]
    [InlineData(4, Math.PI * 16)]
    [InlineData(0, 0)]
    public void CalculateSquare_ShouldReturnCorrectResult(double radius, double expected)
    {
        var circle = new Circle(radius);
        var square = circle.Square;
        Assert.Equal(expected, square, 6);
    }
}