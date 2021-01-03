using System;
using IntroToCsharp.ProjectA.TeamA;

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
            ClassA.Print();
        }    
    }

    namespace ProjectA
    {
        namespace TeamA
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("Print method for Team A");
                }
            }
        }
    }
}
