namespace Homework8;
class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
 /*       Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }   
    */

    
      static void ArraySum(int[] int_array){
        int sum = 0;
        Array.ForEach(int_array, i => sum += i);
        
 Console.WriteLine("The Sum of int_array is : "+ sum);

}   
      static void PrintAllOddNumber(int[,] array_2d){
    foreach(int val in array_2d){
        if(val % 2 != 0)
      Console.Write(val + " ");
    }
    }
    }
    }

    
    /*
     static void ElementSum(int[,] array_2d){
      int total = 0;
      foreach(int n in array_2d);{
        total += n;
        Console.WriteLine(total);
      }
    }   
        static void DoubleArray(int[ , ] array_2d){
            Console.WriteLine("Q3: The new 2d array: ");
        foreach(int n in array_2d){
            Console.Write(n*2 + " ");
      }
        }


*/



