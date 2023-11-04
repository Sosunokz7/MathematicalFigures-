using MathematicalFigures.Domain.Interfaces;

namespace MathematicalFigures.DomainService.Interfaces.Interfaces.Facades;

/// <summary>
/// Идея с фасадами состояла в том, что-бы не создавать лишнии зависимости с кастамными классами пользователей
/// </summary>
public interface ITriangleCalculatorFacade
{
	decimal TriangleAreaCalculatorByThreeSides(ITriangle triangle);
	string IsRightTriangle(ITriangle triangle);
}