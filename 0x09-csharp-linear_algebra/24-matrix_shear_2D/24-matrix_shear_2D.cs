/// <summary>
/// Contains methods to make operations about matrices
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.
	/// </summary>
	/// <param name="matrix">a square 2D matrix</param>
	/// <param name="direction">x or y</param>
	/// <param name="factor">number</param>
	/// <returns>The resulting matrix. If the matrix is of an invalid size, return a matrix containing -1.
	/// If given an axis that is not x or y, return a matrix containing -1.</returns>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] { { -1 } };

		if (direction == 'x')
		{
			matrix[0, 0] += factor * matrix[0, 1];
			matrix[1, 0] += factor * matrix[1, 1];
			return matrix;
		}

		if (direction == 'y')
		{
			matrix[0, 1] += factor * matrix[0, 0];
			matrix[1, 1] += factor * matrix[1, 0];
			return matrix;
		}

		return new double[,] { { -1 } };
	}
}
