using System;


namespace IntroToCsharp
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

        
    }

    public class PartTimeEmployee : Employee
    {

    }

    public class FullTimeEmployee : Employee
    {

    }

    public class TemporaryEmployee : Employee
    {

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

            Employee[] employees = new Employee[4];

            //employees[1] = new Employee();
        }
    }
}

    