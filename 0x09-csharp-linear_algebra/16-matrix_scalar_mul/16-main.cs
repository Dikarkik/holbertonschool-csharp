using System;

class Program
{
	static void Main(string[] args)
	{
		double[,] matrix, res;

		matrix = new double[3, 3] { {-13, 10, 8 }, { 2, 0, 14 }, {-4, -5, 2 } };

		res = MatrixMath.MultiplyScalar(matrix, 4); // (-52, 40, 32) (8, 0, 56) (-16, -20, 8)

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (j == 0)
					Console.Write("(");

				Console.Write($"{res[i, j]}");

				if (j == matrix.GetLength(1) - 1)
					Console.WriteLine(")");
				else
					Console.Write(", ");
			}
		}
	}
}
