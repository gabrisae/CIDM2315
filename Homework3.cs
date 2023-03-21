namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        //Question 1
    /*    Console.WriteLine("Input an integer:");
        int n1 = Convert.ToInt16(Console.ReadLine());
        int counter = 0;
       
        for(int p = 2; p <= n1-1; p++)
        {
            if (n1 % p ==0)
            {
               counter++;
            }
        }
            
        if(counter >0){
            Console.WriteLine("N is non-prime");
        }
        else{
            Console.WriteLine("N is prime");
            */
            
        //Question 2
         Console.WriteLine("Input an integer:");
            int s, i, j;
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (i = 1; i <= s; i++) {
                for (j = 1; j <= s; j++) {
                    Console.Write("*");
                }
                Console.WriteLine("");
            
    
        //Question 3
  /*     Console.WriteLine("Input an integer:");
         int i,j,rows;    
        rows= Convert.ToInt32(Console.ReadLine());   
        for(i=1;i<=rows;i++)
        {
	    for(j=1;j<=i;j++)
	   Console.Write("*");
	    Console.Write("\n");
       */

       // Bonus Question
  /*  Console.WriteLine("Input an integer:");
     int i,j,rows;
   rows= Convert.ToInt32(Console.ReadLine());   
   for(i=1;i<=rows;i++)
   {
	for(j=1;j<=i;j++)
    Console.Write("{0}",j);
	Console.Write("\n");
    */


   }
  }
}

   

 
        
    



  /*      int n=5, a=0;
        for (int i =1; i <= n; i++){
            if (n % i == 0) {
                a++;
            }
        }
        if(a == 2){
            Console.WriteLine("{0} is a Prime Number", n);

        }else{
            Console.WriteLine("Not a Prime Number");
        }
        Console.ReadLine();
        */
       
    
