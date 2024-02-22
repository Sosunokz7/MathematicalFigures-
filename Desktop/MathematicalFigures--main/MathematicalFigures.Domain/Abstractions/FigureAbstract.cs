using MathematicalFigures.Domain.Interfaces.Figures;

namespace MathematicalFigures.Domain.Abstractions;

public abstract class FigureAbstract : IFigure
{
	public abstract decimal CalculateArea();
}