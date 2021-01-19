/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that calculates the inverse of a 2D matrix and returns the resulting matrix.
	/// </summary>
	/// <param name="matrix">double[2,2]</param>
	/// <returns>The resulting matrix. If the matrix is not a 2D matrix, return -1
	/// If the matrix is non-invertible, return -1</returns>
	public static double[,] Inverse2D(double[,] matrix)
	{
		double[,] result = matrix;
		double determinant, save_number;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] { { -1 } };

		determinant = Determinant2D(result[0, 0], result[0, 1], result[1, 0], result[1, 1]);

		if (determinant == 0)
			return new double[,] { { -1 } };

		save_number = result[0, 0];
		result[0, 0] = result[1, 1];
		result[0, 1] = -result[0, 1];
		result[1, 1] = save_number;
		result[1, 0] = -result[1, 0];

		for (int y = 0; y < 2; y++)
		{
			for (int x = 0; x < 2; x++)
			{
				result[y, x] = result[y, x] / determinant;
			}
		}

		return result;
	}

	// example (1, 2) (3, 4) -> a = 1, b = 2, c = 3, d = 4
	private static double Determinant2D(double a, double b, double c, double d)
	{
		return (a * d) - (c * b);
	}
}
