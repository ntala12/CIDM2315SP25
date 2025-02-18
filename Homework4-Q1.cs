namespace Homework4;

class Program
  {
    static void Main(string[] args)
    {
        int a = 3;
        int b = 5;

        int largest =
        LargestNumber.FindLargest(a, b); //Add LargestNumber

        Console.WriteLine("a = " + a + "; b = " + b);
        Console.WriteLine("The largest number is: " + largest);
    }
  }
  public class LargestNumber
  {
    //Method to find the largest of two numbers
    public static int FindLargest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else{
            return num2;
        }
    }
  }
