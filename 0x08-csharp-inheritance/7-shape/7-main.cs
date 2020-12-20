using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();
        aRect.Width = 7;
        aRect.Height = 4;
        Console.WriteLine($"{nameof(aRect)} is of type: {aRect.GetType()}");
        Console.WriteLine("Area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());
        
        Console.WriteLine("\n------------------\n");

        Shape aShape = new Rectangle();
        // aShape.Width = 7; can't do this :(
        // aShape.Height = 4; can't do this :(
        Console.WriteLine($"{nameof(aShape)} is of type: {aShape.GetType()}");
        Console.WriteLine("Area: {0}", aShape.Area());
        Console.WriteLine(aShape.ToString());
    }
}
