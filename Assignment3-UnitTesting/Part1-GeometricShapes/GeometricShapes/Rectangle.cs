namespace Assignment3_UnitTesting.Part1_GeometricShapes.GeometricShapes;

public class Rectangle(double length, double width) : IShape
{
    private readonly double length = length;
    private readonly double width = width;

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculateVolume()
    {
        return 0;
    }
}