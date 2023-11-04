namespace MathematicalFigures.Domain.Interfaces;

/// <summary>
/// Можно добавить различные свойства присущие кругу, но пока нет смысла
/// </summary>
public interface ICircle : IFigure
{
	decimal Radius { get; }

	/// <summary>
	/// Диаметре нужен, что-бы было веселее ;)
	/// /// </summary>
	decimal Diameter { get; }
}