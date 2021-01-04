using System;


namespace IntroToCsharp
{
    public class Employee
    {
        string FirstName;
        string LastName;
        string Email;

        public void PrintFullName()
        {

        }
    }

    public class FullTimeEmployee : Employee
    {
        float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        float HourlySalary;
    }
    class Program
    {
        static void AnotherMethod()
        {
            Console.WriteLine("Learning C# in another method.");
        }
        static void Main()
        {
            Console.WriteLine("Learning C# again.");
            AnotherMethod();
            Program program = new Program();
        }
    }
}

    