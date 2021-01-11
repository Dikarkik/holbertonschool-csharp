using System;

/// <summary>
/// Contains methods to make operations about vectors
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar and returns the resulting vector.
    /// The numbers are rounded to the nearest tenth.
    /// </summary>
    /// <param name="vector">double[] with 2 or 3 values</param>
    /// <param name="scalar">number</param>
    /// <returns>The resulting vector. If any vector is not a 2D or 3D vector, return a vector containing -1</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            return new double[2] { Math.Round(vector[0] * scalar), Math.Round(vector[1] * scalar) };
        }
        else if (vector.Length == 3)
        {
            return new double[3] { Math.Round(vector[0] * scalar), Math.Round(vector[1] * scalar), Math.Round(vector[2] * scalar) };
        }

        return new double[1] { -1 };
    }
}
