using MathematicalFigures.Domain.Aggregates.Figures;
using MathematicalFigures.Domain.Enums;

namespace MathematicalFigures.Tests;

public class TriangleTests
{
	[Fact]
	public void TriangleAreaCalculatorByThreeSides_Equal_5_62_Success()
	{
		//Arrange
		TriangleFigure triangleAreaCalculatorByThreeSides = new TriangleFigure(3,4,4);

		//Act
		decimal result = triangleAreaCalculatorByThreeSides.CalculateArea();

		//Assert
		Assert.Equal(Math.Round(result,3),5.562m);
	}


	[Fact]
	public void TriangleIsRightTriangleCheck_IsTrue_Success()
	{
		//Arrange
		TriangleFigure triangleAreaCalculatorByThreeSides = new TriangleFigure(3,4,5);

		//Act
		TriangleTypesEnum result = triangleAreaCalculatorByThreeSides.GetTriangleType();

		//Assert
		Assert.Equal(result,TriangleTypesEnum.RightAngled);
	}

	[Fact]
	public void TriangleIsRightTriangleCheck_IsFalse_Success()
	{
		//Arrange
		TriangleFigure triangleAreaCalculatorByThreeSides = new TriangleFigure(3,4,1);

		//Act
		TriangleTypesEnum result = triangleAreaCalculatorByThreeSides.GetTriangleType();

		//Assert
		Assert.NotEqual(result,TriangleTypesEnum.RightAngled);
	}
}