using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Triangles;

namespace MathematicalFigures.DomainService.Interfaces.Dto;

internal class TriangleAreaCalculatorModel
{
	internal IAreaFigureCalculator<ITriangle> TriangleAreaCalculatorByThreeSides { get; init; }

	internal ITriangleChecker IsRightTriangle { get; init; }
}