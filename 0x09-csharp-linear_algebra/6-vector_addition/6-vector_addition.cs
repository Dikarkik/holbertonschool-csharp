using System;

/// <summary>
/// Contains methods to make operations about vectors
/// </summary>
public class VectorMath
{
	/// <summary>
	/// Method that adds two vectors and returns the resulting vector (2D and 3D).
	/// The numbers are rounded to the nearest tenth.
	/// </summary>
	/// <param name="vector1">double[] with 2 or 3 values</param>
	/// <param name="vector2">double[] with 2 or 3 values</param>
	/// <returns>The resulting vector. If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing -1</returns>
	public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            return new double[2] { Math.Round(vector1[0] + vector2[0], 2), Math.Round(vector1[1] + vector2[1], 2) };
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            return new double[3] { Math.Round(vector1[0] + vector2[0], 2), Math.Round(vector1[1] + vector2[1], 2), Math.Round(vector1[2] + vector2[2], 2) };
        }

        return new double[1] { -1 };
    }
}
