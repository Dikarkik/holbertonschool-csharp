using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix1, matrix2, res;

		// example 1
		matrix1 = new double[2, 2] { { 2, 3 }, { -1, 0 } };
		matrix2 = new double[2, 2] { { 1, 7 }, { -8, -2 } };
		res = MatrixMath.Multiply(matrix1, matrix2); // (-22, 8) (-1, -7)
		PrintMatrix(res);

		// example 2
		matrix1 = new double[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
		matrix2 = new double[3, 2] { { 7, 8 }, { 9, 10 }, { 11, 12 } };
		res = MatrixMath.Multiply(matrix1, matrix2); // (58, 64) (139, 154)
		PrintMatrix(res);

		// example 3
		matrix1 = new double[1, 3] { { 1, 2, 3 } };
		matrix2 = new double[3, 1] { { 4 }, { 5 }, { 6 } };
		res = MatrixMath.Multiply(matrix1, matrix2); // (32)
		PrintMatrix(res);

		// example 4
		matrix1 = new double[3, 1] { { 4 }, { 5 }, { 6 } };
		matrix2 = new double[1, 3] { { 1, 2, 3 } };
		res = MatrixMath.Multiply(matrix1, matrix2); // (4, 8, 12) (5, 10, 15) (6, 12, 18)
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
