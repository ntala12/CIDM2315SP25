﻿namespace Question2;

class Program
{
    public class SmallestNumber
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Please input the first num:");
         int num1=
            Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Please input the second num:");
        int num2=
            Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please input the third num:");
        int num3=
            Convert.ToInt16(Console.ReadLine());
        
        int smallest = num1; //Assume the first number is the smallest initially
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }
            Console.WriteLine("The smallest value is: " + smallest);
        }
    }
}
