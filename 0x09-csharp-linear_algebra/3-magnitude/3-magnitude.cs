using System;

/// <summary>
/// Contains methods to make operations about vectors
/// </summary>
public class VectorMath
{
	/// <summary>
	/// Method that calculates and returns the length of a given vector (2D and 3D).
	/// The result is rounded to the nearest tenth.
	/// </summary>
	/// <param name="vector">double[] with 2 or 3 values</param>
	/// <returns>The length of a given vector. -1 if the vector is not 2D or 3D</returns>
	public static double Magnitude(double[] vector)
	{
		if (vector.Length == 2)
		{
			var length = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
			return Math.Round(length, 2);
		}
		else if (vector.Length == 3)
		{
			var length = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
			return Math.Round(length, 2);
		}

		return -1;
	}
}
