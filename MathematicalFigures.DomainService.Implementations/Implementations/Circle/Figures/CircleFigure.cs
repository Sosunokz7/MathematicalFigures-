using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Implementations.Implementations.Circle.Areas;
using MathematicalFigures.DomainService.Interfaces.Dto;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

namespace MathematicalFigures.DomainService.Implementations.Implementations.Circle.Figures;

public class CircleFigure : ICircle,IFigureWithArea
{
	private readonly CircleAreaCalculatorModel _circleAreaCalculatorModel;

	public decimal Radius { get; set; }

	public decimal Diameter { get; set; }

	/// <summary>
	/// По хорошему нужно принимать фабричные методы через конструкторы, но оставим это на ToDo:
	/// </summary>
	public CircleFigure()
	{
		_circleAreaCalculatorModel = new CircleAreaCalculatorModel()
		{
				CircleAreaCalculatorByDiameter = new CircleAreaCalculatorByDiameter(),
				CircleAreaCalculatorByRadius = new CircleAreaCalculatorByRadius(),
		};
	}

	public virtual decimal CircleAreaCalculatorByDiameter()
		=> _circleAreaCalculatorModel.CircleAreaCalculatorByDiameter.CalculateArea(this);

	public virtual decimal CircleAreaCalculatorByRadius()
		=> _circleAreaCalculatorModel.CircleAreaCalculatorByRadius.CalculateArea(this);

	public virtual decimal CalculateAreaDefault()
		=> CircleAreaCalculatorByDiameter();
}