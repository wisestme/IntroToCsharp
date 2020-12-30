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
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName);
        }
    }
}
