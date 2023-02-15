namespace AreaCalculator.Figures;

public class Circle : Figure
{
    public double Radius { get; }

    public override double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle radius must be non negative.");
        }
        
        Radius = radius;
    }
}