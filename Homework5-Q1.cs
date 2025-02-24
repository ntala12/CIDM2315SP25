namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        int largest = GetLargest(num1, num2);
        Console.WriteLine($"a={num1}; b={num2}");
        Console.WriteLine($"The largest number is: {largest}");
        
    }
    static int GetLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }
}
