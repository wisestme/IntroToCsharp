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

            Calculate(10, 20, out int Add, out int Multiply);
            Console.WriteLine($"Sum = {Add} and Product = {Multiply}");
        }

        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
        
    }
}
