using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Areas;
using MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Checkers;
using MathematicalFigures.DomainService.Interfaces.Dto;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

namespace MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Figures;

public class TriangleFigure : ITriangle,IFigureWithArea
{
	public decimal AB { get; set; }

	public decimal BC { get; set; }

	public decimal CA { get; set; }


	private readonly TriangleAreaCalculatorModel _triangleAreaCalculator;

	/// <summary>
	/// По хорошему нужно принимать фабричные методы через конструкторы, но оставим это на ToDo:
	/// </summary>
	public TriangleFigure()
	{
		_triangleAreaCalculator = new TriangleAreaCalculatorModel()
		{
				TriangleAreaCalculatorByThreeSides = new TriangleAreaCalculatorByThreeSides(),
				IsRightTriangle = new TriangleIsRightTriangleCheck(),
		};
	}


	public virtual decimal TriangleAreaCalculatorByThreeSides()
		=> _triangleAreaCalculator.TriangleAreaCalculatorByThreeSides.CalculateArea(this);

	public virtual string IsRightTriangle()
	{
		return _triangleAreaCalculator.IsRightTriangle.Check(this)
				? "Это прямоугольный треугольник."
				: "Это не прямоугольный треугольник.";
	}

	public decimal CalculateAreaDefault()
		=> TriangleAreaCalculatorByThreeSides();
}