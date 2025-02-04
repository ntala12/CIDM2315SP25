namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
    //Question 1
    Console.WriteLine("Please input a letter grade: ");
       char letterGrade = 
       Console.ReadKey().KeyChar; 
       Console.WriteLine();
       
       letterGrade = char.ToUpper(letterGrade);
       
        switch (letterGrade)
            { case 'A':
                Console.WriteLine("GPA point: 4");
            break;
              case 'B':
                Console.WriteLine("GPA point: 3");
            break;
              case 'C':
                Console.WriteLine("GPA point: 2");
            break;
              case 'D':
                Console.WriteLine("GPA point: 1");
            break;
              case 'F':
                Console.WriteLine("GPA point: 0");
            break;
        default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
        }
    }
}
