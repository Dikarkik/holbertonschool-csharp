using System;

/// <summary>
/// Contains methods to make operations about vectors
/// </summary>
class VectorMath
{
	/// <summary>
	/// Method that calculates dot product of either two 2D or two 3D vectors.
	/// </summary>
	/// <param name="vector1">double[] with 2 or 3 values</param>
	/// <param name="vector2">double[] with 2 or 3 values</param>
	/// <returns>If any vector is not a 2D or 3D vector, or both vectors are not the same size, return -1</returns>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length == 2 && vector2.Length == 2)
		{
			return Math.Round((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]));
		}
		else if (vector1.Length == 3 && vector2.Length == 3)
		{
			return Math.Round((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]));
		}

		return -1;
	}
}
