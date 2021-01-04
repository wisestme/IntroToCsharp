using System;


namespace IntroToCsharp
{
    class Circle
    {
        float _PI = 3.141F;
        int _Radius;

        public Circle(int Radius)
        {
            _Radius = Radius;
        }

        public float CalculateArea()
        {
            return _PI * _Radius * _Radius;
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
            Program program = new Program();

            Circle circleOne = new Circle(5);

            float circleOneArea = circleOne.CalculateArea();
            Console.WriteLine(($"Area of circle 1 is {circleOneArea}"));

        }
    }
}

    