using MathFiguresSquare.Shapes;

namespace MathFiguresSquare.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(0)]
    [InlineData(1f)]
    [InlineData(1d)]
    [InlineData(Math.PI)]
    [InlineData(Math.E)]
    [InlineData(double.MaxValue)]
    [InlineData(double.Epsilon)]
    [InlineData(double.PositiveInfinity)]
    public void CorrectRadius_ReturnsCircleWithSpecifiedRadius(double radius)
    {
        // Arrange
        
        // Act
        var circle = new Circle(radius);

        // Assert
        Assert.Equal(radius, circle.Radius);
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(double.NegativeZero)]
    [InlineData(double.NaN)]
    [InlineData(double.NegativeInfinity)]
    public void RadiusOutOfRange_ThrowsArgumentOutOfRangeException(double radius)
    {
        // Arrange
        
        // Act

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }
}