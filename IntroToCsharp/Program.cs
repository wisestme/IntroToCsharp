using System;


namespace IntroToCsharp
{
    class Customer
    {
        string _firstName;
        string _lastName;
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

    