using System;
using NUnit.Framework;

namespace Mindbox.Primitive.Tests;

[TestFixture]
public class TriangleTests
{
	[TestCase(-1, 4, 5)]
	[TestCase(5, -0.5, 13)]
	[TestCase(8, 15, -1)]
	[TestCase(1, 2, 3)]
	public void Triangle_InvalidTriangle(double sideA, double sideB, double sideC)
	{
		// Act & Assert
		Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
	}

	[TestCase(3, 4, 5, ExpectedResult = true)]
	[TestCase(5, 12, 13, ExpectedResult = true)]
	[TestCase(8, 15, 17, ExpectedResult = true)]
	[TestCase(7, 8, 9, ExpectedResult = false)] 
	public bool Triangle_IsRectangularTriangle(double sideA, double sideB, double sideC)
	{
		// Act
		Triangle triangle = new Triangle(sideA, sideB, sideC);

		// Assert
		return triangle.IsRectangularTriangle;
	}

	[TestCase(3, 4, 5, ExpectedResult = 6)]
	[TestCase(5, 12, 13, ExpectedResult = 30)]
	[TestCase(8, 15, 17, ExpectedResult = 60)]
	public double Triangle_GetSquare(double sideA, double sideB, double sideC)
	{
		// Act
		Triangle triangle = new Triangle(sideA, sideB, sideC);

		// Assert
		return triangle.GetSquare();
	}
}
