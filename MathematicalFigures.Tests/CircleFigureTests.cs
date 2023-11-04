using MathematicalFigures.DomainService.Implementations.Implementations.Circle.Areas;
using MathematicalFigures.DomainService.Implementations.Implementations.Circle.Figures;

namespace MathematicalFigures.Tests;

public class CircleFigureTests
{
	[Fact]
	public void CircleAreaCalculatorByDiameter_Equal_962_113_Success()
	{
		//Arrange
		CircleAreaCalculatorByDiameter circleAreaCalculatorByDiameter = new CircleAreaCalculatorByDiameter();
		//Act
		decimal result = Math.Round(circleAreaCalculatorByDiameter.CalculateArea(new CircleFigure() {Diameter = 35}),3);
		//Assert
		Assert.Equal(result,962.113m);
	}

	[Fact]
	public void CircleAreaCalculatorByRadius_Equal_314_159_Success()
	{
		//Arrange
		CircleAreaCalculatorByRadius circleAreaCalculatorByDiameter = new CircleAreaCalculatorByRadius();
		//Act
		decimal result = Math.Round(circleAreaCalculatorByDiameter.CalculateArea(new CircleFigure() {Radius = 10}),3);
		//Assert
		Assert.Equal(result,314.159m);
	}
}