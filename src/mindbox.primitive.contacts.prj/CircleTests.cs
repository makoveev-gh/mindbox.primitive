using System;
using NUnit.Framework;

namespace Mindbox.Primitive.Tests;

[TestFixture]
public class CircleTests
{
	[TestCase(5.0)]
	[TestCase(10.0)]
	[TestCase(15.5)]
	public void Circle_Constructor_ValidRadius(double radius)
	{
		// Act
		Circle circle = new Circle(radius);

		// Assert
		Assert.That(circle.Radius, Is.EqualTo(radius));
	}

	[TestCase(0)]
	[TestCase(-5.0)]
	[TestCase(-10.0)]
	[TestCase(-15.5)]
	public void Circle_Constructor_InvalidRadius(double radius)
	{
		// Act & Assert
		Assert.Throws<ArgumentException>(() => new Circle(radius));
	}

	[TestCase(5.0, ExpectedResult = 78.53981633974483)]
	[TestCase(10.0, ExpectedResult = 314.1592653589793)]
	[TestCase(15.5, ExpectedResult = 754.76763502494782d)]
	public double Circle_GetSquare(double radius)
	{
		// Arrange
		Circle circle = new Circle(radius);

		// Act
		return circle.GetSquare();
	}
}
