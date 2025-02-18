﻿namespace Homework4_Q2_2;

class Program
{
    static void Main()
    {
        PrintTriangle(5, "right");
    }

    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N: {N}");
        Console.WriteLine($"Shape: {shape}");

        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}