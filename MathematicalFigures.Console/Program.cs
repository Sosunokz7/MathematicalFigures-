#region

using System.Diagnostics;
using MathematicalFigures.Console.Models.Figures;
using MathematicalFigures.Domain.Interfaces;
using MathematicalFigures.DomainService.Implementations.Implementations.Triangle.Figures;
using MathematicalFigures.DomainService.Interfaces.Interfaces.Services.Abstractions;

#endregion


// IFigureWithArea circleCalculatorFacade = new CustomCircle();
// IFigureWithArea triangle = new CustomTriangle()
// {
// 		AB = 1,
// 		BC = 2,
// 		CA = 3,
// };
RandomFactoryFigures randomFactoryFigures = new RandomFactoryFigures();
IFigureWithArea figureWithArea = randomFactoryFigures.Create();


Console.WriteLine(figureWithArea.CalculateAreaDefault());


public class RandomFactoryFigures
{
	private Lazy<Random> _random = new Lazy<Random>(() => new Random());

	public IFigureWithArea Create()
	{
		int randomResult = _random.Value.Next(0,2);

		if (randomResult == 1)
		{
			Console.WriteLine("Был создан круг.");
			return new CustomCircle()
			{
					Diameter = 4,
					Radius = 2,
			};
		}

		Console.WriteLine("Был создан не круг.");
		return new TriangleFigure()
		{
				AB = 3,
				BC = 4,
				CA = 5,
		};
	}
}