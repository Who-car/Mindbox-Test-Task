using MathFiguresSquare.Shapes;

namespace MathFiguresSquare.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(new double[] {1, 1, 1})]
    [InlineData(new double[] {3, 4, 5})]
    [InlineData(new double[] {5, 12, 13})]
    [InlineData(new double[] {7, 24, 25})]
    [InlineData(new double[] {6, 8, 10})]
    [InlineData(new double[] {double.MaxValue, double.MaxValue, double.MaxValue})]
    public void CorrectSides_ReturnsTriangleWithSpecifiedSides(double[] sides)
    {
        // Arrange
        
        // Act
        var triangle = new Triangle(sides[0], sides[1], sides[2]);

        // Assert
        Assert.Equal(sides[0], triangle.SideA);
        Assert.Equal(sides[1], triangle.SideB);
        Assert.Equal(sides[2], triangle.SideC);
    }
    
    [Theory]
    [InlineData(new double[] {3, 4, 5})]
    [InlineData(new double[] {5, 12, 13})]
    [InlineData(new double[] {1.5, 2, 2.5})]
    [InlineData(new double[] {6, 8, 10})]
    [InlineData(new double[] {3.6, 4.8, 6})]
    public void RightAngledTriangle_ReturnsTrue(double[] sides)
    {
        // Arrange
        
        // Act
        var triangle = new Triangle(sides[0], sides[1], sides[2]);

        // Assert
        Assert.True(triangle.IsRightAngled());
    }
    
    [Theory]
    [InlineData(new double[] {1, 1, 1})]
    [InlineData(new double[] {2, 2, 3})]
    [InlineData(new double[] {1.5, 1.5, 2})]
    [InlineData(new double[] {2.5, 2.5, 3.5})]
    [InlineData(new double[] {4.5, 4.5, 5.5})]
    public void NotRightAngledTriangle_ReturnsFalse(double[] sides)
    {
        // Arrange
        
        // Act
        var triangle = new Triangle(sides[0], sides[1], sides[2]);

        // Assert
        Assert.False(triangle.IsRightAngled());
    }
    
    [Theory]
    [InlineData(new double[] {-1, -1, -1})]
    [InlineData(new double[] {-3, 4, 5})]
    [InlineData(new double[] {5, -12, 13})]
    [InlineData(new double[] {7, 24, -25})]
    [InlineData(new double[] {0, 0, 0})]
    [InlineData(new double[] {double.MinValue, double.MinValue, double.MinValue})]
    [InlineData(new double[] {double.MaxValue, double.MinValue, double.MaxValue})]
    [InlineData(new double[] {double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity})]
    [InlineData(new double[] {double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity})]
    [InlineData(new double[] {double.NaN, double.NaN, double.NaN})]
    public void RadiusOutOfRange_ThrowsArgumentOutOfRangeException(double[] sides)
    {
        // Arrange
        
        // Act

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sides[0], sides[1], sides[2]));
    }
}