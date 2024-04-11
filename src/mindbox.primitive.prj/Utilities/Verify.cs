using System;

namespace Mindbox.Primitive.Utilities;

public static class Verify
{
	private const double _epsilon = double.Epsilon;

	public static void IsValidCircle(double radius)
	{
		if(radius < _epsilon)
			throw new ArgumentException("Некорретно указан радиус круга.", nameof(radius));
	}

	public static void IsValidTriangle(double sideA, double sideB, double sideC)
	{
		if(sideA < _epsilon) throw new ArgumentException("Некорретно указана сторона треугольника.", nameof(sideA));

		if(sideB < _epsilon) throw new ArgumentException("Некорретно указана сторона треугольника.", nameof(sideB));

		if(sideC < _epsilon) throw new ArgumentException("Некорретно указана сторона треугольника.", nameof(sideC));

		double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
		double sumOfOtherSides = sideA + sideB + sideC - maxSide;

		if(!(maxSide < sumOfOtherSides && sumOfOtherSides > 0))
			throw new ArgumentException("Некорретно заданы стороны треугольника.");
	}
}

