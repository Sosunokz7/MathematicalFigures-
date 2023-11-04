using MathematicalFigures.Domain.Interfaces;

namespace MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

public interface IAreaFigureCalculator<in TFigure>
		where TFigure : IFigure
{
	decimal CalculateArea(TFigure figure);
}