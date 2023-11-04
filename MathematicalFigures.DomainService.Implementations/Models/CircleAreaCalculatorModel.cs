using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

namespace MathematicalFigures.DomainService.Interfaces.Dto;


internal class CircleAreaCalculatorModel
{
	public IAreaFigureCalculator<ICircle> CircleAreaCalculatorByRadius { get; init; }

	public IAreaFigureCalculator<ICircle> CircleAreaCalculatorByDiameter { get; init; }
}