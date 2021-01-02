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
            program.EvenNumbers();
        }

        public void EvenNumbers()
        {
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
