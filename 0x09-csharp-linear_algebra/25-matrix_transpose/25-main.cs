using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix, res;

		// example 1
		matrix = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
		res = MatrixMath.Transpose(matrix); // (1, 4, 7) (2, 5, 8) (3, 6, 9)
		PrintMatrix(res);

		// example 2
		matrix = new double[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8} };
		res = MatrixMath.Transpose(matrix); // (1, 3, 5, 7) (2, 4, 6, 8)
		PrintMatrix(res);

		// example 3
		matrix = new double[0, 0];
		res = MatrixMath.Transpose(matrix); // ()
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
