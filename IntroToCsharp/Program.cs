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

            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            foreach(int Number in Numbers)
            {
                Console.WriteLine(Number);
            }

            for(int i = 0; i < 20; i++)
            {
                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }
    }
}
