namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer:");
        int n =
        int.Parse(Console.ReadLine());
        if (IsPrime(n))
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");

        }
        }
        static bool IsPrime(int n)
        {
            if (n <=1)
            {
                return false;
            }
            if (n <=1)
            {
                return true;
            }
            //Check divisibility from 2 to the square root of n
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
