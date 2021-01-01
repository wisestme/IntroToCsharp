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

            
            string UserAnswer;
            do
            {
                Console.WriteLine("Please enter your target number");
                string UserTargetString = Console.ReadLine();

                bool ConvertTarget = int.TryParse(UserTargetString, out int UserTarget);

                if (ConvertTarget)
                {
                    int count = 0;
                    while (count < UserTarget)
                    {
                        Console.WriteLine(count);
                        count++;
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                
                do
                {
                    Console.WriteLine("Do you want to continue? -Yes or No ?");
                    UserAnswer = Console.ReadLine();

                    if (UserAnswer.ToLower() != "yes" && UserAnswer.ToLower() != "no")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }
                } while (UserAnswer.ToLower() != "yes" && UserAnswer.ToLower() != "no");
            } while (UserAnswer.ToLower() == "yes");
            
            
        }
    }
}
