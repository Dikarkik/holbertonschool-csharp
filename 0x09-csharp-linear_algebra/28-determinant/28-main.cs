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
}
