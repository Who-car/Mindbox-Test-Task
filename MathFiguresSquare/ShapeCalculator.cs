namespace MathFiguresSquare;

public static class ShapeCalculator
{
    public static double CalculateShapesArea(params IShape[] shapes)
    {
        return shapes.Sum(shape => shape.Square);
    }
}