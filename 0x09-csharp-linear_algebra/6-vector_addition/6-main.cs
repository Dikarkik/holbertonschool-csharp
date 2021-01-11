using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1, vector2, sum;

        vector1 = new double[3] { 14, -2, 0 };
        vector2 = new double[3] { -3, 23, 50 };
        sum = VectorMath.Add(vector1, vector2); // (11, 21, 50)
        Console.WriteLine($"{(sum[0], sum[1], sum[2])}");

        vector1 = new double[2] { 8, -11 };
        vector2 = new double[2] { -4, 9 };
        sum = VectorMath.Add(vector1, vector2); // (4, -2)
        Console.WriteLine($"{(sum[0], sum[1])}");
    }
}
