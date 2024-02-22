using MathematicalFigures.Domain.Abstractions;

namespace MathematicalFigures.Domain.Aggregates.Figures;

/// <summary>
/// Можно добавить различные свойства присущие кругу, но пока нет смысла
/// </summary>
public class CircleFigure : FigureAbstract
{
	#region Radius

	private decimal _radius;

	public decimal Radius
	{
		get => _radius;
		set
		{
			_radius = value;
			Diameter = _radius * 2;
		}
	}

	#endregion

	#region Diameter

	private decimal _diameter;

	public decimal Diameter
	{
		get => _diameter;
		set
		{
			_diameter = value;
			_radius = _diameter / 2;
		}
	}

	#endregion


	public override decimal CalculateArea()
	{
		return Convert.ToDecimal(Math.PI * Math.Pow((double)Radius,2));
	}
}