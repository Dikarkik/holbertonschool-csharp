using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector;

        vector = new double[3] {7, -3, -9}; // 11.79
        Console.WriteLine($"{VectorMath.Magnitude(vector)}");

        vector = new double[2] {3, 9}; // 9.49
        Console.WriteLine($"{VectorMath.Magnitude(vector)}");
    }
}
