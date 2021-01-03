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

            //int Add;
            //int Multiply;
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            ParamsMethod(Numbers);
            
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("Theere are {0} elements",Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
