using MathematicalFigures.Domain.Interfaces;

namespace MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

public interface IFigureWithArea : IFigure
{
	decimal CalculateAreaDefault();
}