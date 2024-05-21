namespace MathFiguresSquare.Shapes;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA + sideB <= sideC ||
            sideB + sideC <= sideA ||
            sideC + sideA <= sideB)
            throw new ArgumentOutOfRangeException(
                paramName: "Сторона треугольника", 
                message: "Треугольник задан некорректно: не выполняется неравенство треугольника");
        if (double.IsNegative(sideA) ||
            double.IsNegative(sideB) ||
            double.IsNegative(sideC))
            throw new ArgumentOutOfRangeException(
                paramName: "Сторона треугольника", 
                message: "Треугольник задан некорректно: все стороны должны быть неотрицательны");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double Square  
    {
        get
        {
            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
    
    public bool IsRightAngled()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}