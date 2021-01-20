using System;

/// <summary>
/// Contains methods to make operations about vectors
/// </summary>
class VectorMath
{
	/// <summary>
	/// Method that calculates the cross product of two 3D vectors and returns the resulting vector.
	/// </summary>
	/// <param name="vector1">double[3]</param>
	/// <param name="vector2">double[3]</param>
	/// <returns>The resulting vector. If either vector is not a 3D vector, return a vector containing -1</returns>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		double[] result = new double[3];

		if (vector1.Length != 3 || vector2.Length != 3)
			return new double[1] { -1 };

		result[0] = Operation(vector1[1], vector2[2], vector1[2], vector2[1]);
		result[1] = Operation(vector1[2], vector2[1], vector1[0], vector2[2]);
		result[2] = Operation(vector1[0], vector2[1], vector1[1], vector2[0]);

		return result;
	}

	private static double Operation(double a, double b, double c, double d)
	{
		return Math.Round((a * b) - (c * d), 2);
	}
}
