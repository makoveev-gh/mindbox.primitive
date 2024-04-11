using System;

namespace Mindbox.Primitive.Data;
public interface ITriangle : IFigure
{
	double SideA { get; }
	double SideB { get; }
	double SideC { get; }

	bool IsRectangularTriangle { get; }
}
