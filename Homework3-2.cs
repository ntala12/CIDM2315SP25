namespace Homework3_2;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int n=
    int.Parse(Console.ReadLine());
        //Outer loop for rows
        for (int i = 0; i < n; i++)
        {
            //Inner loop for columns
            for (int j = 0; j < n; j++)
            {
                Console.Write("#");
                //Print # for each cell
            }
            Console.WriteLine(); 
            //Move to the next line after each row
        }
    }
}
