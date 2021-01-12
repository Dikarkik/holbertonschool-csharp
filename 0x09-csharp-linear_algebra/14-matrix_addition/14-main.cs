using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix1, matrix2, res;

		matrix1 = new double[3, 3] { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
		matrix2 = new double[3, 3] { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };

		res = MatrixMath.Add(matrix1, matrix2); // (20, 13, 21) (-6, -3, 3) (3, -6, 20)

		for (int i = 0; i < matrix1.GetLength(0); i++)
		{
			for (int j = 0; j < matrix1.GetLength(1); j++)
			{
				if (j == 0)
					Console.Write("(");

				Console.Write($"{res[i, j]}");

				if (j == matrix1.GetLength(1) - 1)
					Console.WriteLine(")");
				else
					Console.Write(", ");
			}
		}
	}
}
