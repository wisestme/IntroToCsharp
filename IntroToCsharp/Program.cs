using System;


namespace IntroToCsharp
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
    }
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

            BaseClass BC = new DerivedClass();
            BC.Print();
        }
    }
}

    