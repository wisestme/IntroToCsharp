using System;


namespace IntroToCsharp
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
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

            FullTimeEmployee FTE = new FullTimeEmployee();

            FTE.FirstName = "Chijioke";
            FTE.LastName = "Nwagwu";
            FTE.Email = "wyhzest@wisestmail.com";
            FTE.PrintFullName();
        }
    }
}

    