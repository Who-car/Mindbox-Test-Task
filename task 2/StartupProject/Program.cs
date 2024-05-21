using MathFiguresSquare;
using MathFiguresSquare.Shapes;

var welcomeText =
    """
    Площадь какой фигуры вы хотите посчитать?
    
    Введите 'c' - для площади круга;
    Введите 't' - для площади треугольника;
    Нажмите 'Ctrl + C' для завершения программы
    """;

while (true)
{
    Console.WriteLine(welcomeText);
    var shapeChosen = Console.ReadLine();
    double square;

    switch (shapeChosen)
    {
        case "c":
            double radius;
            while (true)
            {
                Console.WriteLine("Введите радиус круга (в см):");
                var rawRadius = Console.ReadLine();

                if (!double.TryParse(rawRadius, out radius) || radius < 0)
                {
                    Console.WriteLine("Некорректное значение. Пожалуйста введите вещественное неотрицательное число");
                    continue;
                }
                
                break;
            }
            
            var circle = new Circle(radius);
            square = ShapeCalculator.CalculateShapesArea(circle);
            Console.WriteLine($"Площадь круга радиуса {radius} см равна {square.ToString("#.000")} кв.см");
            break;
        
        case "t":
            double sideA;
            double sideB;
            double sideC;
            while (true)
            {
                Console.WriteLine("Введите через пробел стороны треугольника (в см):");
                var rawSides = Console.ReadLine();
                if (rawSides is null || rawSides.Split().Length != 3)
                {
                    Console.WriteLine("Некорректное значение. Пожалуйста введите через пробел три вещественных неотрицательных числа");
                    continue;
                }
                var sides = rawSides.Split();
                if (!double.TryParse(sides[0], out sideA) || sideA < 0 ||
                    !double.TryParse(sides[1], out sideB) || sideB < 0 ||
                    !double.TryParse(sides[2], out sideC) || sideC < 0)
                {
                    Console.WriteLine("Некорректное значение. Пожалуйста введите через пробел три вещественных неотрицательных числа");
                    continue;
                }
                
                break;
            }
            
            var triangle = new Triangle(sideA, sideB, sideC);
            square = ShapeCalculator.CalculateShapesArea(triangle);
            Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB} и {sideC} см равна {square.ToString("#.000")} кв.см");
            break;
        default:
            Console.WriteLine("Выбранная вами форма пока недоступна, попробуйте что-нибудь ещё");
            break;
    }
}

