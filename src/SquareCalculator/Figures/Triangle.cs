using SquareCalculator.Interfaces;

namespace SquareCalculator.Figures;

public class Triangle : IFigure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }
    

    private double[] _sortedSides;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _sortedSides = new[] {firstSide, secondSide, thirdSide}
            .OrderByDescending(s => s)
            .ToArray();

        if (!IsTriangle(firstSide, secondSide, thirdSide))
        {
            throw new ArgumentException("Triangles sides must be non negative and satisfy the triangle inequality.");
        }

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public double CalculateSquare()
    {
        var p = (FirstSide + SecondSide + ThirdSide) * 0.5;
        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
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