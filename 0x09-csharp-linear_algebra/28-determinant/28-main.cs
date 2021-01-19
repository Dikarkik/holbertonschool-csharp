using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix;

		// example 1
		matrix = new double[2, 2] { { 2, 2 }, { -9, 4 } };
		Console.WriteLine(MatrixMath.Determinant(matrix)); // 26

		// example 2
		matrix = new double[3, 3] { { -4, 9, 0 }, { 1, -2, 1 }, { 3, -4, 2} };
		Console.WriteLine(MatrixMath.Determinant(matrix)); // 9

		// example 3
		matrix = new double[1, 2] { { 1, 2 }};
		Console.WriteLine(MatrixMath.Determinant(matrix)); // -1
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
