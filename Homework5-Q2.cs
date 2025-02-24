namespace Homework5_Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer:");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fourth integer:");
        int num4 = int.Parse(Console.ReadLine());

        int largest = GetLargestOfFour(num1, num2, num3, num4);
        Console.WriteLine($"a={num1}; b={num2}; c={num3}; d={num4}");
        Console.WriteLine($"The largest number is: {largest}");
    }
static int GetLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }
    static int GetLargestOfFour(int a, int b, int c, int d)
    {
        int largestAB = GetLargest(a, b);
        int largestCD = GetLargest(c, d);
        return GetLargest(largestAB, largestCD);
    }
}
