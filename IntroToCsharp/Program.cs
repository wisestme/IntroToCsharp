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

            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            Console.WriteLine(EvenNumbers[1]);

            int[] OddNumbers = new int[4];

            OddNumbers[0] = 1;
            OddNumbers[1] = 3;
            OddNumbers[2] = 5;
            OddNumbers[3] = OddNumbers[2] + 2;

            Console.WriteLine(OddNumbers[3]);
        }
    }
}
