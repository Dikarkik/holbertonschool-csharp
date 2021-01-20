using System;

/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
	/// </summary>
	/// <param name="matrix">a square 2D matrix</param>
	/// <param name="angle">angle in radians</param>
	/// <returns>The resulting matrix. If the matrix is of an invalid size, return a matrix containing -1</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] result, rotationMatrix;

		// If 'matrix' is not a 2D matrix
		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] { { -1 } };

		// 'rotationMatrix' is used in the process to rotate 'matrix'
		rotationMatrix = GetRotationMatrix(angle);

		result = new double[2, 2];

		result[0, 0] = Math.Round((rotationMatrix[0, 0] * matrix[0, 0]) + (rotationMatrix[1, 0] * matrix[0, 1]), 2);

		result[0, 1] = Math.Round((rotationMatrix[0, 1] * matrix[0, 0]) + (rotationMatrix[1, 1] * matrix[0, 1]), 2);

		result[1, 0] = Math.Round((rotationMatrix[0, 0] * matrix[1, 0]) + (rotationMatrix[1, 0] * matrix[1, 1]), 2);

		result[1, 1] = Math.Round((rotationMatrix[0, 1] * matrix[1, 0]) + (rotationMatrix[1, 1] * matrix[1, 1]), 2);

		return result;
	}

	/// Method that creates a new 2D matrix and rotate their vectors in radians.
	/// Note: This matrix is used in the process to rotate an existing matrix.
	/// The 'basis vectors' of this matrix are (0, 1) (1, 0).
	/// Returns: The resulting 2D matrix
	private static double[,] GetRotationMatrix(double angle)
	{
		double[,] rotationMatrix = new double[2, 2];

		rotationMatrix[0, 0] = Math.Cos(angle); // vector i (x)
		rotationMatrix[0, 1] = Math.Sin(angle); // vector i (y)
		rotationMatrix[1, 0] = -Math.Sin(angle); // vector j (x)
		rotationMatrix[1, 1] = Math.Cos(angle); // vector j (y)

		return rotationMatrix;
	}
}
