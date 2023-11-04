using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

namespace MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Areas;

/// <summary>
///  Класс рассчитывает площадь треугольника через 3 стороны  
/// </summary>
public class TriangleAreaCalculatorByThreeSides : IAreaFigureCalculator<ITriangle>
{
	public decimal CalculateArea(ITriangle figure)
	{
		decimal p = (figure.AB + figure.BC + figure.CA) / 2;
		decimal s = p * (p - figure.AB) * (p - figure.BC) * (p - figure.CA);
		s = (decimal)Math.Sqrt((double)s);
		return s;
	}
}