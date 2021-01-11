using System;


namespace IntroToCsharp
{    
    public class Student
    {
        private int _id;
        private string _name;
        private int _passmark;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id must be greater than zero");
            }
            this._id = Id;
        }

        public int  GetId()
        {
            return this._id;
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

            Student firstStudent = new Student();
            firstStudent.SetId(100);

            Console.WriteLine($"ID = {firstStudent.GetId()}");
        }
    }
}

    