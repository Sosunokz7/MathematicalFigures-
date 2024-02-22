#region

using MathematicalFigures.Domain.Abstractions;
using MathematicalFigures.Domain.Aggregates.Figures;

#endregion


RandomFactoryFigures randomFactoryFigures = new RandomFactoryFigures();
FigureAbstract figureWithArea = randomFactoryFigures.Create();


Console.WriteLine(figureWithArea.CalculateArea());


public class RandomFactoryFigures
{
	private Lazy<Random> _random = new Lazy<Random>(() => new Random());

	public FigureAbstract Create()
	{
		int randomResult = _random.Value.Next(0,2);

		if (randomResult == 1)
		{
			Console.WriteLine("Был создан круг.");
			return new CircleFigure()
			{
					Diameter = 4,
			};
		}

		Console.WriteLine("Был треугольник.");
		return new TriangleFigure(3,4,5);

	}
}