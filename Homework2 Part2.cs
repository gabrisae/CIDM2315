namespace Homework2Smallestvalue;
class Program
{
    static void Main(string[] args)
    {
       
       int num1, num2, num3;
       Console.WriteLine("Please input the first num:");
       int num1 = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Please input the second num:");
       int num2 = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Please input the third num:");
       int num3 = Convert.ToInt16(Console.ReadLine());

        if(n1 < n2){
            if(n1 < n3){
                Console.WriteLine("The smallest value is: n1");
            }
            else{
                Console.WriteLine("The smallest value is: n3");
            }
        }
        else{
            if(n2 < n3){
                Console.WriteLine("The smallest value is: n2");
            }
            else{
                Console.WriteLine("The smallest value is: n3");
            }
        }



        }



}       
