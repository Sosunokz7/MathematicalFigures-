using System.ComponentModel;

namespace MathematicalFigures.Domain.Enums;

public enum TriangleTypesEnum : byte
{
	[Description("Равносторонний треугольник")]
	EquilateralTriangle = 0,
	
	[Description("Прямоугольный треугольник")]
	RightAngled = 1,
}