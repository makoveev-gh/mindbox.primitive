using System;
using Mindbox.Primitive.Data;
using Mindbox.Primitive.Utilities;

namespace Mindbox.Primitive;
public class Circle : IFigure
{
	/// <summary>
	/// .tor
	/// </summary>
	/// <param name="radius">Радиус круга.</param>
	/// <exception cref="ArgumentException"></exception>
	public Circle(double radius)
	{
		Verify.IsValidCircle(radius);

		Radius = radius;
	}

	/// <summary>Радиус круга.</summary>
	public double Radius { get; }

	/// <inheritdoc/>>
	public double GetSquare()
	{
		return Math.PI * Math.Pow(Radius, 2d);
	}
}
