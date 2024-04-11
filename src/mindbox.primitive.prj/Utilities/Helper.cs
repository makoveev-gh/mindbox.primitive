using System;

namespace Mindbox.Primitive.Utilities;
public static class Helper
{
	public static void Exchange<T>(ref T a, ref T b)
	{
		T temp = a;
		a = b;
		b = temp;
	}
}