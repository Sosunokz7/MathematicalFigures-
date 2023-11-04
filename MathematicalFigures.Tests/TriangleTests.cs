using MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Areas;
using MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Checkers;
using MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Figures;

namespace MathematicalFigures.Tests;

public class TriangleTests
{
	[Fact]
	public void TriangleAreaCalculatorByThreeSides_Equal_5_62_Success()
	{
		//Arrange
		TriangleAreaCalculatorByThreeSides
				triangleAreaCalculatorByThreeSides = new TriangleAreaCalculatorByThreeSides();

		//Act
		decimal result = triangleAreaCalculatorByThreeSides.CalculateArea(new TriangleFigure()
		{
				AB = 3,
				BC = 4,
				CA = 4,
		});

		//Assert
		Assert.Equal(Math.Round(result,3),5.562m);
	}


	[Fact]
	public void TriangleIsRightTriangleCheck_IsTrue_Success()
	{
		//Arrange
		TriangleIsRightTriangleCheck triangleAreaCalculatorByThreeSides = new TriangleIsRightTriangleCheck();

		//Act
		bool result = triangleAreaCalculatorByThreeSides.Check(new TriangleFigure()
		{
				AB = 3,
				BC = 4,
				CA = 5,
		});

		//Assert
		Assert.True(result);
	}
	
	[Fact]
	public void TriangleIsRightTriangleCheck_IsFalse_Success()
	{
		//Arrange
		TriangleIsRightTriangleCheck triangleAreaCalculatorByThreeSides = new TriangleIsRightTriangleCheck();

		//Act
		bool result = triangleAreaCalculatorByThreeSides.Check(new TriangleFigure()
		{
				AB = 3,
				BC = 4,
				CA = 1,
		});

		//Assert
		Assert.False(result);
	}
}