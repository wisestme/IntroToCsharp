using System;


namespace IntroToCsharp
{    
    public class Student
    {
        public int ID;
        public string Name;
        public int Passmark;
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

            Student firstStudent = new Student();
            firstStudent.ID = -20;
            firstStudent.Name = null;
            firstStudent.Passmark = 0;

            Console.WriteLine($"ID = {firstStudent.ID}, and Passmark = {firstStudent.Passmark} while Name = {firstStudent.Name}");
        }
    }
}

    