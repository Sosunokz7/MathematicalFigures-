using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Triangles;

namespace MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Checkers;

/// <summary>
///  Класс проверяет является ли треугольник прямоугольным  
/// </summary>
public class TriangleIsRightTriangleCheck : ITriangleChecker
{
	public bool Check(ITriangle triangle)
	{
		double[] sides = new[] {triangle.AB,triangle.BC,triangle.CA}.Select(s => (double)s)
				.OrderBy(orb => orb)
				.ToArray();

		return Math.Pow(sides[0],2) + Math.Pow(sides[1],2) == Math.Pow(sides[2],2);
	}
}