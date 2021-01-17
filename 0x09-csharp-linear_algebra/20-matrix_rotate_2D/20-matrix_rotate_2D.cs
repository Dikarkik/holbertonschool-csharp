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
		double[,] result, rotatedMatrix;

		// If 'matrix' is not a 2D matrix
		if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
			return new double[,] { { -1 } };

		// 'rotatedMatrix' is used in the process to rotate 'matrix'
		rotatedMatrix = GetRotatedMatrix(angle);

		result = new double[2, 2];

		// iterate 'result' matrix and ask for every 'dot product'
		for (int y = 0; y < 2; y++)
		{
			for (int x = 0; x < 2; x++)
			{
				result[y, x] = MultiplyColAndRow(rotatedMatrix, matrix, x, y);
			}
		}

		return result;
	}

	/// Method that creates a new 2D matrix and rotate their vectors in radians.
	/// Note: This matrix is used in the process to rotate an existing matrix.
	/// The 'basis vectors' of this matrix are (0, 1) (1, 0).
	/// Returns: The resulting 2D matrix
	private static double[,] GetRotatedMatrix(double angle)
	{
		double[,] rotatedMatrix = new double[2, 2];

		rotatedMatrix[0, 0] = Math.Round(Math.Cos(angle), 2); // vector i (x)
		rotatedMatrix[0, 1] = Math.Round(Math.Sin(angle), 2); // vector i (y)
		rotatedMatrix[1, 0] = -Math.Round(Math.Sin(angle), 2); // vector j (x)
		rotatedMatrix[1, 1] = Math.Round(Math.Cos(angle), 2); // vector j (y)

		return rotatedMatrix;
	}

	// Return the dot product of the col of matrix1 and the row of matrix2
	private static double MultiplyColAndRow(double[,] matrix1, double[,] matrix2, int col, int row)
	{
		double sum = 0;

		for (int i = 0; i < 2; i++)
			sum += matrix1[i, col] * matrix2[row, i];

		return sum;
	}
}
