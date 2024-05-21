namespace MathFiguresSquare.Shapes;

public class Circle : IShape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        if (double.IsNegative(radius))
            throw new ArgumentOutOfRangeException("Радиус круга должен быть неотрицательным");
        
        Radius = radius;
    }
    
    public double Square
    {
        get
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}