using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

namespace MathematicalFigures.DomainService.Implementations.Implementations.Circle.Areas;

/// <summary>
/// Класс рассчитывает площадь круга через диаметре
/// /// </summary>
/// <typeparam name="TCircle">Круг</typeparam>
public class CircleAreaCalculatorByDiameter : IAreaFigureCalculator<ICircle>
{
	public decimal CalculateArea(ICircle figure)
	{
		decimal result = (decimal)(0.25 * Math.PI * Math.Pow((double)figure.Diameter,2));
		return result;
	}
}