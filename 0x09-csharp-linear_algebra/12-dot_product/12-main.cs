using System;

class Program
{
	static void Main(string[] args)
	{
		double[] vector1, vector2;

		vector1 = new double[3] { -4, 0, 10 };
		vector2 = new double[3] { 3, 7, -9 }; // -102
		Console.WriteLine($"{VectorMath.DotProduct(vector1, vector2)}");

		vector1 = new double[2] { 1, 3 };
		vector2 = new double[2] { -2, 5 }; // 13
		Console.WriteLine($"{VectorMath.DotProduct(vector1, vector2)}");
	}
}
