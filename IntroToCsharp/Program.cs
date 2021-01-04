using System;


namespace IntroToCsharp
{
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name = {_firstName} {_lastName}");
        }
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
            Customer customerOne = new Customer("Chijioke", "Nwagwu");

            customerOne.PrintFullName();
            

        }
    }
}

    