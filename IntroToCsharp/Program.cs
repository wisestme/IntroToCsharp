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
            Program program = new Program();
            program.EvenNumbers(30);
        }

        public void EvenNumbers(int stopNumber)
        {
            for (int i = 0; i <= stopNumber; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
