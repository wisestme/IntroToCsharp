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

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee employee in employees)
            {
                employee.PrintFullName();
            }
        }
    }
}

    