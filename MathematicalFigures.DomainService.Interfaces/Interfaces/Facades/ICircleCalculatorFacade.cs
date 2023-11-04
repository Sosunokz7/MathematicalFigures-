using MathematicalFigures.Domain.Interfaces;

namespace MathematicalFigures.DomainService.Interfaces.Interfaces.Facades;

/// <summary>
/// Идея с фасадами состояла в том, что-бы не создавать лишнии зависимости с кастамными классами пользователей
/// </summary>
public interface ICircleCalculatorFacade

{
	decimal CircleAreaCalculatorByDiameter(ICircle circle);
	decimal CircleAreaCalculatorByRadius(ICircle circle);
}