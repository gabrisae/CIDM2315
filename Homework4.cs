namespace Homework4;
class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("\nInput first integer:");  
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input second integer:");  
        int b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("a = " + a + ";" + " b = " +b);
        Console.WriteLine("The largest number is: "+(Math.Max(a, b)));
    }
}


/*
namespace Homework4._2;
class Program
{
    
    static void Main(string[] args)
    {

        Console.WriteLine("N is: 5; shape is left");
        for(int i=1; i <= 5; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            
           Console.Write("*");
        }

        Console.WriteLine();
        }
            Console.Read();
        
        }
    }
*/
