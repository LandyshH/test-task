namespace AreaCalculator.Figures;

public class Triangle : Figure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public override double Area
    {
        get
        {
            var p = (FirstSide + SecondSide + ThirdSide) * 0.5;
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }

    private readonly double[] _sortedSides;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (!IsTriangleValid(firstSide, secondSide, thirdSide))
        {
            throw new ArgumentException("Triangles sides must be non negative and satisfy the triangle inequality.");
        }
        
        _sortedSides = new[] {firstSide, secondSide, thirdSide}
            .OrderByDescending(s => s)
            .ToArray();

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }
    
    public bool IsRectangular()
    {
        return
            Math.Abs(_sortedSides[0] * _sortedSides[0] - _sortedSides[1] * _sortedSides[1] - _sortedSides[2] * _sortedSides[2]) 
            < double.Epsilon;
    }

    private bool IsTriangleValid(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}