using System;

class Program
{
	static void Main(string[] args)
	{
		double[] vector1, vector2;

		// example 1
		vector1 = new double[3] { 2, -2, 1 };
		vector2 = new double[3] { -8, 8, -4 };
		PrintVector(VectorMath.CrossProduct(vector1, vector2)); // (0, 0, 0)

		// example 2
		vector1 = new double[3] { 2, 3, 4 };
		vector2 = new double[3] { 5, 6, 7 };
		PrintVector(VectorMath.CrossProduct(vector1, vector2)); // (-3, 6, -3)

		// example 3
		vector1 = new double[1] { 1 };
		vector2 = new double[3] { 5, 6, 7 };
		PrintVector(VectorMath.CrossProduct(vector1, vector2)); // (-1)
	}

	private static void PrintVector(double[] vector)
	{
		for (int i = 0; i < vector.Length; i++)
		{
			if (i == 0)
				Console.Write("(");

			Console.Write($"{vector[i]}");

			if (i == vector.Length -1)
				Console.WriteLine(")");
			else
				Console.Write(", ");
		}
		Console.WriteLine();
	}
}
