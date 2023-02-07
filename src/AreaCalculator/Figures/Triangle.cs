using AreaCalculator.Interfaces;

namespace AreaCalculator.Figures;

public class Triangle : IFigure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public double Area
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
        if (!IsTriangle(firstSide, secondSide, thirdSide))
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
    
    public bool IsRightTriangle()
    {
        return
            Math.Abs(_sortedSides[0] * _sortedSides[0] - _sortedSides[1] * _sortedSides[1] - _sortedSides[2] * _sortedSides[2]) 
            < double.Epsilon;
    }

    private bool IsTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}