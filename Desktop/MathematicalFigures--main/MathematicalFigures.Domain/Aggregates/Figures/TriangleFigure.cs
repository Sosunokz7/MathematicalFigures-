using MathematicalFigures.Domain.Abstractions;
using MathematicalFigures.Domain.Enums;

namespace MathematicalFigures.Domain.Aggregates.Figures;

public class TriangleFigure : FigureAbstract
{
	public decimal AB { get; set; }

	public decimal BC { get; set; }

	public decimal CA { get; set; }


	public TriangleFigure(decimal ab,decimal bc,decimal ca)
	{
		AB = ab;
		BC = bc;
		CA = ca;
	}

	public override decimal CalculateArea()
	{
		decimal p = (AB + BC + CA) / 2;
		decimal s = p * (p - AB) * (p - BC) * (p - CA);
		s = (decimal)Math.Sqrt((double)s);
		return s;

	}

	public virtual TriangleTypesEnum GetTriangleType()
	{
		double[] sides = new[] {AB,BC,CA}.Select(s => (double)s).OrderBy(orb => orb).ToArray();
		return Math.Pow(sides[0],2) + Math.Pow(sides[1],2) == Math.Pow(sides[2],2)
				? TriangleTypesEnum.RightAngled
				: TriangleTypesEnum.EquilateralTriangle;
	}
}