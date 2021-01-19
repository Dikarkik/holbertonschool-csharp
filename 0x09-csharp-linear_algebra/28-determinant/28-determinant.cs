/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that calculates the determinant of a matrix 2D or 3D.
	/// </summary>
	/// <param name="matrix">double[,]</param>
	/// <returns>the determinant of matrix. If the matrix is not 2D or 3D, return -1</returns>
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			return Determinant2D(matrix[0, 0], matrix[0, 1], matrix[1, 0], matrix[1, 1]);
		}

		if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double part1 = matrix[0, 0] * Determinant2D(matrix[1, 1], matrix[1, 2], matrix[2, 1], matrix[2, 2]);
			double part2 = matrix[0, 1] * Determinant2D(matrix[1, 0], matrix[1, 2], matrix[2, 0], matrix[2, 2]);
			double part3 = matrix[0, 2] * Determinant2D(matrix[1, 0], matrix[1, 1], matrix[2, 0], matrix[2, 1]);

			return part1 - part2 + part3;
		}

		return -1;
	}

	// example (1, 2) (3, 4) -> a = 1, b = 2, c = 3, d = 4
	private static double Determinant2D(double a, double b, double c, double d)
	{
		return (a * d) - (c * b);
	}
}
