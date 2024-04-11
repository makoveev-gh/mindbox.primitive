using System;
using Mindbox.Primitive.Data;
using Mindbox.Primitive.Utilities;

namespace Mindbox.Primitive;
public class Triangle : ITriangle
{
	private const double _epsilon = double.Epsilon;
	private readonly bool _isRectangularTriangle;

	/// <summary>
	/// .tor
	/// </summary>
	/// <param name="sideA">Угол треугольника A.</param>
	/// <param name="sideB">Угол треугольника B.</param>
	/// <param name="sideC">Угол треугольника C.</param>
	/// <exception cref="ArgumentException"></exception>
	public Triangle(double sideA, double sideB, double sideC)
	{
		Verify.IsValidTriangle(sideA, sideB, sideC);

		SideA = sideA;
		SideB = sideB;
		SideC = sideC;

		_isRectangularTriangle = GetIsRectangularTriangle();
	}

	public double SideA { get; }
	public double SideB { get; }
	public double SideC { get; }
	public bool IsRectangularTriangle => _isRectangularTriangle;

	/// <inheritdoc/>>
	public double GetSquare()
	{
		var halfPerimeter = (SideA + SideB + SideC) / 2d;
		return Math.Sqrt(
			halfPerimeter
			* (halfPerimeter - SideA)
			* (halfPerimeter - SideB)
			* (halfPerimeter - SideC)
		);
	}

	#region private
	private bool GetIsRectangularTriangle()
	{
		double maxEdge = SideA, b = SideB, c = SideC;

		if(b - maxEdge > _epsilon) Helper.Exchange(ref maxEdge, ref b);

		if(c - maxEdge > _epsilon) Helper.Exchange(ref maxEdge, ref c);

		return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < _epsilon;
	}

	#endregion
}
