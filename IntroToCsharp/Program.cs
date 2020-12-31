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

            Console.WriteLine("Please enter a number");
            bool ConversionSuccess = int.TryParse(Console.ReadLine(), out int userNumber);
            if(ConversionSuccess)
            {
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("You entered an even number");
                }
                else
                {
                    Console.WriteLine("You entered an odd number");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

            Console.WriteLine("Please enter another number");

            bool ConvertSecondNumber = int.TryParse(Console.ReadLine(), out int SecondNumber);

            if (ConvertSecondNumber)
            {
                switch (SecondNumber)
                {
                    case 10:
                        
                    case 20:
                        
                    case 30:
                        Console.WriteLine($"Your second number is {SecondNumber}");
                        break;
                    default:
                        Console.WriteLine("Your number is neither 10, 20 nor 30");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
