/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that adds two matrices and returns the resulting matrix.
	/// </summary>
	/// <param name="matrix1">double[,]</param>
	/// <param name="matrix2">double[,]</param>
	/// <returns>If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		// If matrix1 is not a 2D or 3D matrix
		if (matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3)
			return new double[1, 1] { { -1 } };

		// If both matrices are not the same size
		if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
			return new double[1, 1] { { -1 } };

		var len_y = matrix1.GetLength(0);
		var len_x = matrix1.GetLength(1);
		double[,] sum = new double[len_y, len_x];

		for (int y = 0; y < len_y; y++)
		{
			for (int x = 0; x < len_x; x++)
			{
				sum[y, x] = matrix1[y, x] + matrix2[y, x];
			}
		}

		return sum;
	}
}
