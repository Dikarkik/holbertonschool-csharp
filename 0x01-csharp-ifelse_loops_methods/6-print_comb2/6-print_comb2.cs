using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                if (j > i)
                {
                    if (i == 8 && j ==9)
                        Console.Write($"{i}{j}\n");
                    else
                        Console.Write($"{i}{j}, ");
                }
            }
        }
    }
}
