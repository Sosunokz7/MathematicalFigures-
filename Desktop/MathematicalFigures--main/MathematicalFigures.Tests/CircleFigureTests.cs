using MathematicalFigures.Domain.Aggregates.Figures;

namespace MathematicalFigures.Tests;

public class CircleFigureTests
{
	[Fact]
	public void CircleAreaCalculatorByRadius_Equal_314_159_Success()
	{
		//Arrange
		CircleFigure circleAreaCalculatorByDiameter = new CircleFigure() {Radius = 10};
		//Act
		decimal result = Math.Round(circleAreaCalculatorByDiameter.CalculateArea());
		//Assert
		Assert.Equal(result,314);
	}
}