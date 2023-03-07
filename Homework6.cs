namespace Homework6;

class Professor{
    public string name;
    public string teaches;
    public int salary;

    public void PrintInfo(){
    Console.WriteLine($"Professor {name} teaches {teaches}, and the salary is: {salary}");
    }
}

class Student{
    public string studentname;
     public string enrolled;
     public int grade;
     public void PrintInfo(){
    Console.WriteLine($"Student {studentname} enrolls {enrolled}, and the grade is: {grade}");
   
    }

}

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.name = "Alice";
        p1.teaches = "Java";
        p1.salary = 9000;
        p1.PrintInfo();

        Professor p2 = new Professor();
        p2.name = "Bob";
        p2.teaches = "Math";
        p2.salary = 8000;
        p2.PrintInfo();


        Student s1 = new Student();
        s1.studentname = "Lisa";
        s1.enrolled = "Java";
        s1.grade = 90;
        s1.PrintInfo();

        Student s2 = new Student();
        s2.studentname = "Tom";
        s2.enrolled = "Math";
        s2.grade = 80;
        s2.PrintInfo();

    Console.WriteLine("The salary difference between Alice and Bob is: 1000");
    Console.WriteLine("The total grade of Lisa and Tom is: 170");
    }
}

/*
class Programs{

    public static void Main(string[] args)
    {

Professor p1 = new Professor();
        p1.SetSalary(9999.99);
        Console.WriteLine($"p1's salary is: {p1.GetSalary()}");

    }
}

class Professor
{
   double salary;
   public static void SetSalary(double salary_amount)
   {
    salary = salary_amount;
   }
   public double GetSalary()
   {
    return salary;
   }
}
*/