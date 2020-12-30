using System;


namespace IntroToCsharp
{
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

            Console.WriteLine("Please what is your name?");
            string firstName = Console.ReadLine();
            string lastName = "Nwagwu";

            Console.WriteLine("Hello {0}, {1}", firstName, lastName);
        }
    }
}
