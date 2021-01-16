/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that multiplies two matrices and returns the resulting matrix.
	/// The matrices will not necessarily be square or the same dimensions.
	/// </summary>
	/// <param name="matrix1">double[,]</param>
	/// <param name="matrix2">double[,]</param>
	/// <returns>The resulting matrix. If the matrices cannot be multiplied, return a matrix containing -1</returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		// The number of columns of the 1st matrix must equal the number of rows of the 2nd matrix
		if (matrix1.GetLength(1) != matrix2.GetLength(0))
			return new double[1, 1] { { -1 } };

		// The result will have the same number of rows as the 1st matrix, and the same number of columns as the 2nd matrix.
		double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
		int len_y = result.GetLength(0);
		int len_x = result.GetLength(1);

		// iterate 'result' matrix and ask for every 'dot product'
		for (int y = 0; y < len_y; y++)
		{
			for (int x = 0; x < len_x; x++)
			{
				result[y, x] = MultiplyRowAndCol(matrix1, matrix2, y, x);
			}
		}

		return result;
	}

    // Return the dot product of the row of matrix1 and the col of matrix2
	private static double MultiplyRowAndCol(double[,] matrix1, double[,] matrix2, int row, int col)
	{
		double sum = 0;
		int len = matrix1.GetLength(1);

		for (int i = 0; i < len; i++)
			sum += matrix1[row, i] * matrix2[i, col];

		return sum;
	}
}
