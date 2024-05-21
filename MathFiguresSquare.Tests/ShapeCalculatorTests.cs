using MathFiguresSquare.Shapes;

namespace MathFiguresSquare.Tests;

public class ShapeCalculatorTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(3.5, Math.PI * 3.5 * 3.5)]
    [InlineData(0, 0)]
    [InlineData(4.2, Math.PI * 4.2 * 4.2)]
    public void CalculateCircleSquare_ReturnsCircleSquare(double radius, double expectedSquare)
    {
        // Arrange
        var circle = new Circle(radius);
        
        // Act
        var square = ShapeCalculator.CalculateShapesArea(circle);

        // Assert
        Assert.True(Math.Abs(square - expectedSquare) < 1e-10);
    }
    
    [Theory]
    [InlineData(new double[] {3, 4, 5}, 6)]
    [InlineData(new double[] {6, 8, 10}, 24)]
    [InlineData(new double[] {1, 1, 1}, 0.4330127018922193)]
    [InlineData(new double[] {5, 5, 6}, 12)]
    [InlineData(new double[] {7.5, 7.5, 7.5}, 24.356964481430604)] 
    public void CalculateTriangleSquare_ReturnsTriangleSquare(double[] sides, double expectedSquare)
    {
        // Arrange
        var triangle = new Triangle(sides[0], sides[1], sides[2]);
        
        // Act
        var square = ShapeCalculator.CalculateShapesArea(triangle);

        // Assert
        Assert.True(Math.Abs(square - expectedSquare) < 1e-10);
    }
    
    [Theory]
    [InlineData(1, new double[] {3, 4, 5}, Math.PI + 6)]
    [InlineData(2, new double[] {6, 8, 10}, 4 * Math.PI + 24)]
    [InlineData(3.5, new double[] {1, 1, 1}, 38.917522708367184)]
    [InlineData(0, new double[] {5, 5, 6}, 12)]
    [InlineData(4.2, new double[] {7.5, 7.5, 7.5}, 79.774658890782455)]
    public void CalculateCircleAndTriangleSquares_ReturnsTheirTotalSquare(double radius, double[] sides, double expectedSquare)
    {
        // Arrange
        var circle = new Circle(radius);
        var triangle = new Triangle(sides[0], sides[1], sides[2]);
        
        // Act
        var square = ShapeCalculator.CalculateShapesArea(circle, triangle);

        // Assert
        Assert.True(Math.Abs(square - expectedSquare) < 1e-10);
    }
    
    [Fact]
    public void CalculateEmptySequence_ReturnsZero()
    {
        // Arrange
        
        // Act
        var square = ShapeCalculator.CalculateShapesArea();

        // Assert
        Assert.Equal(0, square);
    }
}