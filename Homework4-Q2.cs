namespace Homework4_2;

class Program
{
    static void Main(string[] args)
    {
    PrintTriangle(5, "left");
    }
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N: {N}");
        Console.WriteLine($"Shape: {shape}");

        if (shape.ToLower() == "left" && N == 5)
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
    }
}