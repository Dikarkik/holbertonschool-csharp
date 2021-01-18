using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix, res;

		// example 1
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Rotate2D(matrix, -1.57); // (2, -1) (4, -3)
		PrintMatrix(res);

		// example 2
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Rotate2D(matrix, 3); // (-1.27, -1.84) (-3.53, -3.54)
		PrintMatrix(res);

		// example 3
		matrix = new double[2, 2] { { 1.30, 2.12 }, { 3.98, 4.58 } };
		res = MatrixMath.Rotate2D(matrix, 1.11); // (-1.34, 2.1) (-2.37, 5.6)
		PrintMatrix(res);

		matrix = new double[1, 1] { { 1 } };
		res = MatrixMath.Rotate2D(matrix, 3); // (-1)
		PrintMatrix(res);
	}

	static void PrintMatrix(double[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (j == 0)
					Console.Write("(");

				Console.Write($"{matrix[i, j]}");

				if (j == matrix.GetLength(1) - 1)
					Console.WriteLine(")");
				else
					Console.Write(", ");
			}
		}
		Console.WriteLine();
	}
}
