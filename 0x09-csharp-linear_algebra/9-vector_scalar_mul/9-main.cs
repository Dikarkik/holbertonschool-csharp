using System;

class Program
{
	static void Main(string[] args)
	{
		double[] vector, res;

		vector = new double[3] { 0, -16, 31 };
		res = VectorMath.Multiply(vector, 4); // (0, -64, 124)
		Console.WriteLine($"{(res[0], res[1], res[2])}");

		vector = new double[2] { 98, 972 };
		res = VectorMath.Multiply(vector, 0.5f); // (49, 486)
		Console.WriteLine($"{(res[0], res[1])}");
	}
}
