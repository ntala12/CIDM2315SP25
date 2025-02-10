namespace Homework3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int n =
    int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        //Outer loop for rows
            {
                for (int j = 0; j <= i; j++)
                //Inner loop for columns (up to the current row number)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                //Move to the next line after each row
            }
    }
}
