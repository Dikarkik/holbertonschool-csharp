/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that multiplies a matrix and a scalar and returns the resulting matrix.
	/// </summary>
	/// <param name="matrix">double[,]</param>
	/// <param name="scalar">double</param>
	/// <returns>If the matrix is not a 2D or 3D matrix, return a matrix containing -1</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		if (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
			return new double[1, 1] { { -1 } };

		var len_y = matrix.GetLength(0);
		var len_x = matrix.GetLength(1);
		double[,] res = new double[len_y, len_x];

		for (int y = 0; y < len_y; y++)
		{
			for (int x = 0; x < len_x; x++)
			{
				res[y, x] = matrix[y, x] * scalar;
			}
		}

		return res;
	}
}
