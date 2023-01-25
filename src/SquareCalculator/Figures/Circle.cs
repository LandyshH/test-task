using SquareCalculator.Interfaces;

namespace SquareCalculator.Figures;

public class Circle : IFigure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle radius must be non negative.");
        }
        
        Radius = radius;
    }

    public double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }
}