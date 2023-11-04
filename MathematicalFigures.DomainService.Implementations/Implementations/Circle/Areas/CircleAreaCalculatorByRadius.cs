using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

namespace MathematicalFigures.DomainService.Implementations.Implementations.Circle.Areas;

/// <summary>
/// Класс рассчитывает площадь круга через радиус  
/// </summary>
/// <typeparam name="TCircle">Круг</typeparam>
public class CircleAreaCalculatorByRadius : IAreaFigureCalculator<ICircle>
{
	public virtual decimal CalculateArea(ICircle figure)
	{
		decimal result = Convert.ToDecimal(Math.PI * Math.Pow((double)figure.Radius,2));
		return result;
	}
}