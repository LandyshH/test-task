using AreaCalculator.Interfaces;

namespace AreaCalculator.Figures;

public class Circle : IFigure
{
    public double Radius { get; }

    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle radius must be non negative.");
        }
        
        Radius = radius;
    }
}