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

            int i = 0;
            SimpleMethod(ref i);

            Console.WriteLine(i);
        }

        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }

        
    }
}
