/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method to transpose a matrix and return the resulting matrix.
	/// The matrix can be of any dimension or size.
	/// </summary>
	/// <param name="matrix"></param>
	/// <returns>The resulting matrix. If the matrix is empty, return an empty matrix</returns>
	public static double[,] Transpose(double[,] matrix)
	{
		int len_y = matrix.GetLength(0);
		int len_x = matrix.GetLength(1);
		double[,] result = new double[len_x, len_y];

		for (int y = 0; y < len_y; y++)
		{
			for (int x = 0; x < len_x; x++)
			{
				result[x, y] = matrix[y, x];
			}
		}

		return result;
	}
}
