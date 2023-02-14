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
