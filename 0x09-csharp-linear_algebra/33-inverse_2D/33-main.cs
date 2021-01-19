using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix, res;

		// example 1
		matrix = new double[2, 2] { { 1, 2 }, { 3, 4 } };
		res = MatrixMath.Inverse2D(matrix); // (-2, 1) (1.5, -0.5)
		PrintMatrix(res);

		// example 2
		matrix = new double[2, 2] { { 4, 2 }, { 7, 6 } };
		res = MatrixMath.Inverse2D(matrix); // (0.6, -0.2) (-0.7, 0.4)
		PrintMatrix(res);

		// example 3
		matrix = new double[2, 2] { { 3, 6 }, { 4, 8 } };
		res = MatrixMath.Inverse2D(matrix); // (-1)
		PrintMatrix(res);

		// example 4
		matrix = new double[0, 0];
		res = MatrixMath.Inverse2D(matrix); // (-1)
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
