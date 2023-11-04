namespace MathematicalFigures.Domain.Interfaces;

public interface ITriangle : IFigure
{
	decimal AB { get; }

	decimal BC { get; }

	decimal CA { get; }
}