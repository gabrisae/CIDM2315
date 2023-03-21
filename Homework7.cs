namespace Homework7;
class Program
{
    static void Main(string[] args)
    {

        //Customers
        Customer Alice = new Customer(cus_id:110, cus_age:28, cus_name:"Alice");
        Alice.PrintCusInfo();
        Customer Bob = new Customer(cus_id:111, cus_age:30, cus_name:"Bob");
        Bob.PrintCusInfo();
        
        ChangeId alice1 = new ChangeId(new_id:220, cus_age:28, cus_name:"Alice");
        alice1.PrintNewInfo();
        ChangeId bob1 = new ChangeId(new_id:221, cus_age:30, cus_name:"Bob");
        bob1.PrintNewInfo();

       CustAge alice = new CustAge(28, "Alice");
       CustAge bob = new CustAge(30, "Bob");
       alice.CompareAge(bob);
    
    } 

}

class CustAge{
    public int cus_age {get;set;} = 0;
    public string cus_name {get;set;} = string.Empty;
    public CustAge(int cus_age, string cus_name){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }

    public void CompareAge(CustAge objCust){
        if(this.cus_age <= objCust.cus_age){
            Console.WriteLine($"{objCust.cus_name} is older");
            
        }else{
            Console.WriteLine($"{this.cus_name} is older");
        }
    }
}

class Customer{
     private int cus_id {get;set;} = 0;
    public string cus_name {get;set;} = string.Empty;
    public int cus_age = 0;

    public Customer(int cus_id, int cus_age, string cus_name){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
        this.cus_id= cus_id;
    }
   
   public void PrintCusInfo(){
       Console.WriteLine($"Customer: {this.cus_id}, name: {this.cus_name}, age:{this.cus_age}");    
    }

}

   class ChangeId{
    private int new_id {get;set;} = 0;
    public string cus_name {get;set;} = string.Empty;
    public int cus_age = 0;
    public ChangeId(int cus_age, string cus_name, int new_id){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
        this.new_id= new_id;

   }
   public void PrintNewInfo(){
   Console.WriteLine($"Customer: {this.new_id}, name: {this.cus_name}, age:{this.cus_age}");
   }
    }



