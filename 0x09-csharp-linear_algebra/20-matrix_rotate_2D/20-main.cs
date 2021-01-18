using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix, res;

		// example 1
		matrix = new double[2, 2] { { 1, 3 }, { 2, 4 } };
		res = MatrixMath.Rotate2D(matrix, -1.57); // (2, 4) (-1, -3)
		PrintMatrix(res);

		// example 2
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Rotate2D(matrix, 3); //(-1.41, -2.54) (-2.83, -3.68)
		PrintMatrix(res);

		// example 3
		matrix = new double[2, 2] { { 1.30, 2.12 }, { 3.98, 4.58 } };
		res = MatrixMath.Rotate2D(matrix, 1.11); // (-3.01, -3.19) (2.92, 3.92)
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
