using MathematicalFigures.Domain.Interfaces;

namespace MathematicalFigures.DomainService.Interfaces.Interfaces.Triangles;

public interface ITriangleChecker
{
	bool Check(ITriangle triangle);
}